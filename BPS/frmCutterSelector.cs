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
    public partial class frmCutterSelector : Form
    {
        List<clsMachine> lstMachine = clsMachine.getCutterMachineList();
        Label lblParentSender;

        public frmCutterSelector()
        {
            InitializeComponent();
        }

        public frmCutterSelector(Label lblSender)
        {
            InitializeComponent();
            lblParentSender = lblSender;
        }

        private void frmCutterSelector_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < lstMachine.Count; i++)
                cmbCutter.Items.Add(lstMachine[i]);
        }

        private void cmbCutter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCutter.SelectedIndex > -1)
            {
                lblArms.Text = ((clsMachine)cmbCutter.SelectedItem).Cutter.arms.ToString();
                lblUtilWidth.Text = ((clsMachine)cmbCutter.SelectedItem).Cutter.utilWidth.ToString();                
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            lblParentSender.Tag = cmbCutter.SelectedItem;
            this.Close();
        }
    }
}
