using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmTester : Form
    {
        public frmTester()
        {
            InitializeComponent();
        }

        private void frmTester_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("yy").Substring(1));
            //MessageBox.Show(System.Diagnostics.FileVersionInfo.GetVersionInfo(
              //  System.Reflection.Assembly.GetExecutingAssembly().Location.ToString()).ProductVersion);
            //MessageBox.Show(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
            //MessageBox.Show(Application.ProductVersion.ToString());
            //MessageBox.Show(System.Reflection.Assembly.GetExecutingAssembly().GetName().FullName.ToString());
            //MessageBox.Show(
            //System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString());
            //if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            //    MessageBox.Show(System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Major.ToString() + "." +
            //        System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Minor.ToString() + "." +
            //        System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Build.ToString() + "." +
            //        System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision.ToString());
            
        }
    }
}
