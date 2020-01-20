using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using BPS.Raw.Process.Out;

namespace BPS.Raw.Helper
{
    public partial class frmLoginH : Form
    {
        public frmReProRaw parentReProRaw;

        string strCaller = "";
        public int attempts;
        public bool isAuth;

        public frmLoginH()
        {
            InitializeComponent();
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
        }

        public frmLoginH(frmReProRaw winReProRaw)
        {
            InitializeComponent();
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
            parentReProRaw = winReProRaw;
            strCaller = "reProRaw";
        }

        private void frmLoginH_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                if ((txtUsername.Text == "materia.prima" && txtPassword.Text == "MPBOPP"))
                {
                    isAuth = true;
                    if (strCaller == "reProRaw")
                        parentReProRaw.isAutoricet = true;
                    this.Close();
                }
                else if (attempts < 2)
                    attempts++;
                else
                {
                    if (strCaller == "reProRaw")
                        parentReProRaw.isAutoricet = false;
                    this.Close();
                }
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (this.lblMessage.ForeColor == Color.Red)
            {
                this.lblMessage.Text = "";
                this.lblMessage.ForeColor = Color.Black;
            }
        }

        private void frmLoginH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isAuth == false)
            {
                parentReProRaw.isAutoricet = false;
                this.Close();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                btnOK_Click(new object(), new EventArgs());
        }
    }
}