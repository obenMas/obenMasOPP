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
    public partial class frmDeliveriesByMonthDate : Form
    {
        public frmDeliveriesByMonthDate()
        {
            InitializeComponent();
        }

        private void btnGenerateRpt_Click(object sender, EventArgs e)
        {
            frmDeliveriesByMonth generateNewReport = new frmDeliveriesByMonth(dtpDBMD.Value.ToString("dd/MM/yyyy"));
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }
    }
}
