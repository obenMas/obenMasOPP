using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication3
{
    public partial class frmAddTuja : Form
    {
        private DataGridView Dgv;

        public frmAddTuja()
        {
            InitializeComponent();
        }

        public frmAddTuja(DataGridView dgv)
        {
            InitializeComponent();
            Dgv = dgv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dgv.Rows.Add();
            Dgv.Rows[Dgv.Rows.Count - 1].Cells["clmCodigo"].Value = textBox1.Text;
            Dgv.Rows[Dgv.Rows.Count - 1].Cells["clmAncho"].Value = textBox2.Text;
            this.Close();
        }



    }
}
