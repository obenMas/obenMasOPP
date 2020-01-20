using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPS.Bussiness;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace ConsoleApplication3
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //}
        //[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPruebas());
        }   

    }
}
