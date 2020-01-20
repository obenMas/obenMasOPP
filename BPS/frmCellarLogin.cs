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
    public partial class frmCellarLogin : Form
    {
        frmReDeliveryPallet prntReDeliveryPallet;
        frmChangeCellar prntChangeCellar;
        frmChangeOrigin prntChangeOrigin;
        frmReturnCoil prntReturn;
        frmMaquileCoil prntMaquile;
        frmShippingMultiple prntMultiple;
        frmSystemConfig prntSystemConfig;
        frmSystemConfigAdmin prntSystemConfigAdmin;

        string strCaller = "";

        public int attempts;
        public bool isAuth;

        public frmCellarLogin()
        {
            InitializeComponent();
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
        }

        public frmCellarLogin(frmReDeliveryPallet parent)
        {
            InitializeComponent();
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
            prntReDeliveryPallet = parent;
            strCaller = "reDelivery";
        }

        public frmCellarLogin(frmSystemConfigAdmin parent)
        {
            InitializeComponent();
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
            prntSystemConfigAdmin = parent;
            strCaller = "systemConfigAdmin";
        }

        public frmCellarLogin(frmSystemConfig parent)
        {
            InitializeComponent();
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
            prntSystemConfig = parent;
            strCaller = "systemConfig";
        }

        public frmCellarLogin(frmChangeCellar parent)
        {
            InitializeComponent();
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
            prntChangeCellar = parent;
            strCaller = "changeCellar";
        }

        public frmCellarLogin(frmChangeOrigin parent)
        {
            InitializeComponent();
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
            prntChangeOrigin = parent;
            strCaller = "changeOrigin";
        }

        public frmCellarLogin(frmReturnCoil parent)
        {
            InitializeComponent();
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
            prntReturn = parent;
            strCaller = "returnCoil";
        }

        public frmCellarLogin(frmMaquileCoil parent)
        {
            InitializeComponent();
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
            prntMaquile = parent;
            strCaller = "maquileCoil";
        }

        public frmCellarLogin(frmShippingMultiple parent)
        {
            InitializeComponent();
            txtUsername.Focus();
            attempts = 0;
            isAuth = false;
            prntMultiple = parent;
            strCaller = "multiple";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            prntReDeliveryPallet.isAutoricet = false;
            prntChangeCellar.isAutoricet = false;
            prntChangeOrigin.isAutoricet = false;
            prntReturn.isAutoricet = false;
            prntMaquile.isAutoricet = false;
            prntMultiple.isAutoricet = false;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                if((txtUsername.Text == "carlos.guañuna" && txtPassword.Text == "bodegaBOPP") || (txtUsername.Text == "admin" && txtPassword.Text == "superBopp2014"))
                {
                    isAuth = true;
                    if (strCaller == "reDelivery")
                        prntReDeliveryPallet.isAutoricet = true;
                    else if (strCaller == "changeCellar")
                        prntChangeCellar.isAutoricet = true;
                    else if (strCaller == "changeOrigin")
                        prntChangeOrigin.isAutoricet = true;
                    else if (strCaller == "returnCoil")
                        prntReturn.isAutoricet = true;
                    else if (strCaller == "maquileCoil")
                        prntMaquile.isAutoricet = true;
                    else if (strCaller == "systemConfig")
                        prntSystemConfig.isAutoricet = true;
                    else if (strCaller == "systemConfigAdmin")
                        prntSystemConfigAdmin.isAutoricet = true;
                    else
                        prntMultiple.isAutoricet = true;
                    this.Close();
                }
                else if (attempts < 2)
                {
                    attempts++;
                    this.pbxInfo.SendToBack();
                    this.lblMessage.Text = "Usuario / contraseña incorrectos";
                    this.lblMessage.ForeColor = Color.Red;
                }
                else
                {
                    if (strCaller == "reDelivery")
                        prntReDeliveryPallet.isAutoricet = false;
                    else if (strCaller == "changeCellar")
                        prntChangeCellar.isAutoricet = false;
                    else if (strCaller == "changeOrigin")
                        prntChangeOrigin.isAutoricet = false;
                    else if (strCaller == "returnCoil")
                        prntReturn.isAutoricet = false;
                    else if (strCaller == "maquileCoil")
                        prntMaquile.isAutoricet = false;
                    else if (strCaller == "systemConfig")
                        prntSystemConfig.isAutoricet = false;
                    else if (strCaller == "systemConfigAdmin")
                        prntSystemConfigAdmin.isAutoricet = false;
                    else
                        prntMultiple.isAutoricet = false;
                    this.Close();
                }
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

        private void frmCellarLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isAuth == false)
            {
                prntReDeliveryPallet.isAutoricet = false;
                prntChangeCellar.isAutoricet = false;
                prntChangeOrigin.isAutoricet = false;
                prntReturn.isAutoricet = false;
                prntMaquile.isAutoricet = false;
                prntMultiple.isAutoricet = false;
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