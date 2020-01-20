using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Raw
{
    public partial class frmLogin : Form
    {
        public int attempts;
        public bool isAuth;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                clsGlobal.LoggedUser = clsUser.Login(txtUsername.Text, txtPassword.Text);

                if (clsGlobal.LoggedUser.codsec > 0)
                {
                    isAuth = true;
                    this.Close();
                }
                else if (attempts < 2)
                {
                    attempts++;
                    this.pbxInfo.SendToBack();
                    this.lblMessage.Text = "Usuario o contraseña incorrectos";
                    this.lblMessage.ForeColor = Color.Red;

                }
                else
                    Application.Exit();
            }
            else
            {
                this.pbxInfo.SendToBack();
                this.lblMessage.Text = "Debe ingresar el usuario";
                this.lblMessage.ForeColor = Color.Red;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (this.lblMessage.ForeColor == Color.Red)
            {
                this.pbxInfo.BringToFront();
                this.lblMessage.Text = "";
                this.lblMessage.ForeColor = Color.Black;
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isAuth == false)
                Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                btnOK_Click(new object(), new EventArgs());
        }
    }
}