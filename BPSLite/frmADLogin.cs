using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmADLogin : Form
    {
        public int attempts;
        public bool isAuth;

        public frmADLogin()
        {
            InitializeComponent();
            attempts = 0;
            isAuth = false;
            string domainUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string[] paramsLogin = domainUser.Split('\\');
            //txtUser.Text = paramsLogin[1].ToString();
            txtUsername.Text = paramsLogin[1].ToString();
            txtPassword.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            string adPath = "LDAP://oppfilm.com.ar";
            clsLDAPAuth adAuth = new clsLDAPAuth(adPath);

            if(!string.IsNullOrEmpty(txtUsername.Text))
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    try
                    {
                        if (true == adAuth.IsAuthenticated("OPPFILM", txtUsername.Text, txtPassword.Text))
                        {
                            clsUser user = new clsUser(txtUsername.Text);
                            if(user.codsec!=0)
                            {
                                clsGlobal.LoggedUser = user;
                                isAuth = true;
                                this.Close();
                            }
                            else
                            {
                                attempts++;
                                if(attempts<3)
                                {
                                    int x = 3 - attempts;
                                    lblError.Text = "Usuario y/o contraseña incorrectos. Quedan " + x + " intentos.";
                                    txtPassword.Focus();
                                }
                                else
                                {
                                    Application.Exit();
                                }
                            }
                        }
                        else
                        {
                            attempts++;
                            if (attempts < 3)
                            {
                                int x = 3 - attempts;
                                lblError.Text = "Usuario y/o contraseña incorrectos. Quedan " + x + " intentos.";
                                txtPassword.Focus();
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        attempts++;
                        if (attempts < 3)
                        {
                            int x = 3 - attempts;
                            lblError.Text = "Usuario y/o contraseña incorrectos. Quedan " + x + " intentos.";
                            txtPassword.Focus();
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    lblError.Text = "Ingrese una contraseña válida.";
                    txtPassword.Focus();
                }
            }
            else
            {
                lblError.Text = "Ingrese un usuario válido.";
                txtUsername.Focus();
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmADLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isAuth == false)
                Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnOK_Click(new object(), new EventArgs());
            }
        }
    }
}
