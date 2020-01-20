using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ConsoleApplication3
{
    public partial class frmPruebasThreads : Form
    {
        bool sedespacha = false;

        public frmPruebasThreads()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Thread laburante = new Thread(trabajaNegro);
            laburante.Start();


            panel1.Visible = true;
            pictureBox1.Visible = true;
            panel1.BringToFront();
            pictureBox1.BringToFront();

            Thread laburante2 = new Thread(trabajaNegro2);
            laburante2.Start();
            //laburante2.Join();

            MessageBox.Show("El thread anterior quedo laburando", "", MessageBoxButtons.OK);

            if (sedespacha)
            {
                Console.WriteLine("PErfecto viejah");
            }
            else
            {
                Console.WriteLine("Nono.");
            }
        }

        public void trabajaNegro()
        {
            CheckForIllegalCrossThreadCalls = false;

            listBox1.Enabled = false;

            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i);
            }

            Thread.Sleep(10000);

            listBox1.Enabled = true;
        }

        public void trabajaNegro2()
        {
            CheckForIllegalCrossThreadCalls = false;

            listBox2.Enabled = false;

            listBox2.BackColor = Color.LightGreen;

            for (int i = 0; i < 20; i++)
            {
                listBox2.Items.Add(i);
            }

            Thread.Sleep(15000);

            MessageBox.Show("Exitooooo viejaahhh","Don't give a shit",MessageBoxButtons.OK);
            //pictureBox1.Visible = false;
            panel1.Visible = false;
            panel1.SendToBack();

            listBox2.Enabled = true;
            sedespacha = true;
      
        }
    }
}
