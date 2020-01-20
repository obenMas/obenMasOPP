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
    public partial class frmRoundExample : Form
    {
        public frmRoundExample()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] values = { 13.25, 13.2, 12.8, 3.125, 3.135, 3.145 };
            foreach (var item in values)
            {
                MessageBox.Show(Math.Round(item,1).ToString());
            }
            foreach (var item in values)
            {
                MessageBox.Show(Math.Round(item, 1,MidpointRounding.AwayFromZero).ToString());
            }
        }
    }
}
