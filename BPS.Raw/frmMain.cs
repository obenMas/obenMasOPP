using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BPS.Bussiness;
using BPS.Raw.Menu;
using BPS.Raw.ProcessR.Stock;
using BPS.Raw.ProcessR.Line;
using BPS.Raw.ProcessR.Aditive;
using BPS.Raw.Helper;

namespace BPS.Raw
{
    public partial class frmMain : Form
    {
        //Inicio de la Operaciones
        public frmMain()
        {
            frmLogin winLogin = new frmLogin();
            winLogin.ShowDialog();
            //29-09 Nahuel: cambie la compañia a 2, porque 1 no existe.
            clsGlobal.Company.load(2);
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            connectionTyep();
        }

        private void connectionTyep()
        {
            tsslUserName.Text = clsGlobal.LoggedUser.firstName + " " + clsGlobal.LoggedUser.lastName;

            if (clsGlobal.DataBaseEngine == "MySql")
                tsslDatabase.Image = global::BPS.Raw.Properties.Resources.sqlserver;
            else
                tsslDatabase.Image = global::BPS.Raw.Properties.Resources.sqlserver;

            tsslDatabase.ToolTipText = clsGlobal.server;

            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                tsslVersion.Text = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Major.ToString() + "." +
                    System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Minor.ToString() + "." +
                    System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Build.ToString() + "." +
                    System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision.ToString();
            else
                tsslVersion.Text = string.Empty;

            validateRol();

        }

        private void validateRol()
        {
            if (clsGlobal.LoggedUser.fkRole == 1026)
            {
                btnIn.Visible = false;
                btnOut.Visible = false;
                btnReturn.Visible = false;
                btnAd.Visible = false;
                btnSilo.Visible = false;
                //Nahuel: btnMW no es necesario, solo tenemos linea DMT
                btnMW.Visible = false;
            }
            else
            {
                btnStock.Visible = false;
                btnDMT.Visible = false;
                btnMW.Visible = false;
                btnReportDay.Visible = false;
                //Nahuel: btnRepro no hace nada, lo dejo invisible
                //btnSilo.Visible = false;
            }
        }

        #region Raw

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmMenu winMenu = new frmMenu("In", this);
            winMenu.StartPosition = FormStartPosition.Manual;
            winMenu.Location = new System.Drawing.Point(450, 70);
            winMenu.ShowDialog();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            frmMenu winMenu = new frmMenu("Out", this);
            winMenu.StartPosition = FormStartPosition.Manual;
            winMenu.Location = new System.Drawing.Point(450, 70);
            winMenu.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMenu winMenu = new frmMenu("Return", this);
            winMenu.StartPosition = FormStartPosition.Manual;
            winMenu.Location = new System.Drawing.Point(450, 70);
            winMenu.ShowDialog();
        }

        private void btnAd_Click(object sender, EventArgs e)
        {
            /*frmAditive winMenu = new frmAditive();
            winMenu.StartPosition = FormStartPosition.CenterScreen;
            winMenu.MdiParent = this;
            winMenu.Show();*/
            frmBackLoadRawMP winReturn = new frmBackLoadRawMP();
            winReturn.StartPosition = FormStartPosition.CenterScreen;
            winReturn.MdiParent = this;
            winReturn.Show();
        }

        private void btnRePro_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Abastecedor
        private void btnStock_Click(object sender, EventArgs e)
        {
            frmBackLoadRaw winMenu = new frmBackLoadRaw();
            winMenu.StartPosition = FormStartPosition.CenterScreen;
            winMenu.MdiParent = this;
            winMenu.Show();
        }

        private void btnDMT_Click(object sender, EventArgs e)
        {
            frmFormulation winMenu = new frmFormulation("DMT");
            winMenu.StartPosition = FormStartPosition.CenterScreen;
            winMenu.MdiParent = this;
            winMenu.Show();
        }

        private void btnMW_Click(object sender, EventArgs e)
        {
            frmFormulation winMenu = new frmFormulation("MW");
            winMenu.StartPosition = FormStartPosition.CenterScreen;
            winMenu.MdiParent = this;
            winMenu.Show();
        }

        private void btnReportDay_Click(object sender, EventArgs e)
        {
            frmMovementDay winDay = new frmMovementDay();
            winDay.StartPosition = FormStartPosition.CenterScreen;
            winDay.MdiParent = this;
            winDay.Show();
        }
        #endregion

        private void btnSilo_Click(object sender, EventArgs e)
        {
            frmSilos winSilo = new frmSilos();
            winSilo.StartPosition = FormStartPosition.CenterScreen;
            winSilo.MdiParent = this;
            winSilo.Show();
        }
    }
}
