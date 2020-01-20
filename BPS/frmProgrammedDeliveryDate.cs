using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BPS
{
    public partial class frmProgrammedDeliveryDate : Form
    {
        public frmProgrammedDeliveryDate()
        {
            InitializeComponent();
        }

        private void btnGenerateRpt_Click(object sender, EventArgs e)
        {
            frmProgrammedDelivery generateNewReport = new frmProgrammedDelivery(dtpPDD.Value.ToString("dd/MM/yyyy"));
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }
    }
}
