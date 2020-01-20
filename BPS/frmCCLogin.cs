using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmCCLogin : Form
    {
        frmBlockMaterial prntBlockMaterial;

        string strCaller = "";

        public int attempts;
        public bool isAuth;

        public frmCCLogin()
        {
            InitializeComponent();
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
        }

        public frmCCLogin(frmBlockMaterial parent)
        {
            InitializeComponent();
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
            prntBlockMaterial = parent;
            strCaller = "blockMaterial";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            prntBlockMaterial.isAutoricet = false;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                if ((txtUsername.Text == "cornelio.castro" && txtPassword.Text == "CCBOPP") || (txtUsername.Text == "control.calidad" && txtPassword.Text == "CCBOPP"))
                {
                    isAuth = true;
                    if (strCaller == "blockMaterial")
                        prntBlockMaterial.isAutoricet = true;
                    this.Close();
                }
                else if (attempts < 2)
                    attempts++;
                else
                {
                    if (strCaller == "blockMaterial")
                        prntBlockMaterial.isAutoricet = false;
                    this.Close();
                }
            }
        }

        private void frmCellarLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isAuth == false)
            {
                prntBlockMaterial.isAutoricet = false;
                this.Close();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                btnOK_Click(new object(), new EventArgs());
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void pbxSettings_Click(object sender, EventArgs e)
        {

        }

        private void pbxLogin_Click(object sender, EventArgs e)
        {

        }

    }
}