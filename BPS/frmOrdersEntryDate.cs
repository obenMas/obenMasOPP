using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using BPS.Reports.SalesOrder;

namespace BPS
{
    public partial class frmOrdersEntryDate : Form
    {
        public frmOrdersEntryDate()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            frmOrdersEntry generateNewReport = new frmOrdersEntry(dtpOE.Value.ToString("dd/MM/yyyy"));
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

    }
}
