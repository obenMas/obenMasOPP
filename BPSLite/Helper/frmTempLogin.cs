using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite.Helper
{
    public partial class frmTempLogin : Form
    {
        string strCaller = "";

        public int attempts;
        public bool isAuth;
        private frmPalletRegistration prntPalletRegistration;

        public frmTempLogin()
        {
            InitializeComponent();
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
        }

        public frmTempLogin(frmPalletRegistration frmPalletRegistration)
        {
            InitializeComponent();
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
            strCaller = "palletRegister";
            this.prntPalletRegistration = frmPalletRegistration;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            prntPalletRegistration.isAutoricet = false;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && !string.IsNullOrEmpty(txtNotes.Text))
            {
                if ((txtUsername.Text == "supervisor.turno1" && txtPassword.Text == "superT1") ||
                    (txtUsername.Text == "supervisor.turno2" && txtPassword.Text == "superT2") ||
                    (txtUsername.Text == "supervisor.turno3" && txtPassword.Text == "superT3"))
                {
                    isAuth = true;
                    if (strCaller == "palletRegister")
                    {
                        prntPalletRegistration.isAutoricet = true;
                        sendMailInfo();
                    }
                    this.Close();
                }
                else if (attempts < 2)
                {
                    attempts++;
                    MessageBox.Show("Debe ingresar el usuario y/o contraseña incorrectos\nIntentos " + attempts + " de 3");
                }
                else
                {
                    if (strCaller == "palletRegister")
                        prntPalletRegistration.isAutoricet = false;
                    this.Close();
                }
            }
            else
                MessageBox.Show("Debe ingresar el usuario y notas para poder inicial el ambiente\nToma Manual");
        }

        private void sendMailInfo()
        {
            //sendMail.toSendMail("", txtNotes.Text, txtUsername.Text);
        }

        private void frmCellarLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isAuth == false)
            {
                prntPalletRegistration.isAutoricet = false;
                this.Close();
            }
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