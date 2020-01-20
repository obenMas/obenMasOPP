using BPS.Raw.In;
using BPS.Raw.Process.Out;
using BPS.Raw.Return;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPS.Raw.Menu
{
    public partial class frmMenu : Form
    {
        //Menu Generico
        private string source = string.Empty;
        private frmMain frmMain;

        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(string source, frmMain frmMain)
        {
            InitializeComponent();
            this.source = source;
            this.frmMain = frmMain;
            setTitle(source);
            setMenu(source);
        }

        private void setTitle(string source)
        {
            if (source == "In")
                this.Text = "Ingreso de Materia Prima";
            else if (source == "Out")
                this.Text = "Salida de Materia Prima";
            else
                this.Text = "Devolución de Materia Prima";
        }

        private void hideAllPanel()
        {
            foreach (var form in Controls.OfType<Form>())
            {
                if (form.Name == "frmMenu")
                {
                    foreach (var panel in form.Controls.OfType<Panel>())
                    {
                        // Do Something
                        panel.Hide();
                    }
                }
            }
        }

        private void setMenu(string source)
        {
            switch (source)
            {
                case "In":
                    hideAllPanel();
                    generateButtonIn();
                    break;
                case "Out":
                    hideAllPanel();
                    generateButtonOut();
                    break;

                case "Return":
                    hideAllPanel();
                    generateButtonReturn();
                    break;

                default:

                    break;
            }
        }

        #region IN

        private void generateButtonIn()
        {
            pnlIn.BringToFront();
            pnlIn.Show();
            this.Height = 154;
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            this.Close();

            frmInRaw winInRaw = new frmInRaw("Ingreso de Materia Prima" + " a granel", "Granel");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void btnE5_Click(object sender, EventArgs e)
        {
            this.Close();

            frmInRaw winInRaw = new frmInRaw("Ingreso de Materia Prima" + " por paletts", "Pallet");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void btnE31_Click(object sender, EventArgs e)
        {
            this.Close();

            frmInRaw winInRaw = new frmInRaw("Ingreso de Materia Prima" + " Depósito Industrial", "E31");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        #endregion

        #region Out

        private void generateButtonOut()
        {
            pnlOut.BringToFront();
            pnlOut.Show();
            this.Height = 105;
        }

        private void reqDMTH16_Click(object sender, EventArgs e)
        {
            this.Close();

            frmOutRaw winInRaw = new frmOutRaw("Salida de Materia Prima" + " DMT", "H016");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void silo1TS_Click(object sender, EventArgs e)
        {
            this.Close();

            frmOutRaw winInRaw = new frmOutRaw("Salida de Materia Prima" + " Silo 1", "1");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void silo2TS_Click(object sender, EventArgs e)
        {
            this.Close();

            frmOutRaw winInRaw = new frmOutRaw("Salida de Materia Prima" + " Silo 2", "2");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void silo3TS_Click(object sender, EventArgs e)
        {
            this.Close();

            frmOutRaw winInRaw = new frmOutRaw("Salida de Materia Prima" + " Silo 3", "3");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void silo8TS_Click(object sender, EventArgs e)
        {
            this.Close();

            frmOutRaw winInRaw = new frmOutRaw("Salida de Materia Prima" + " Silo 8", "8");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void reqMWH4_Click(object sender, EventArgs e)
        {
            this.Close();

            frmOutRaw winInRaw = new frmOutRaw("Salida de Materia Prima" + " MW - Consumo", "H004");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void reqFH18_Click(object sender, EventArgs e)
        {
            this.Close();

            frmOutRaw winInRaw = new frmOutRaw("Salida de Materia Prima" + " Formulaciones - Consumo", "H018");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void reqAH5_Click(object sender, EventArgs e)
        {
            this.Close();

            frmOutRaw winInRaw = new frmOutRaw("Salida de Materia Prima" + " Aluminio - Consumo", "H005");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void transCH17_Click(object sender, EventArgs e)
        {
            this.Close();

            frmOutRaw winInRaw = new frmOutRaw("Salida de Materia Prima Calderón - Consumo", "H017");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void ventaLS19_Click(object sender, EventArgs e)
        {
            this.Close();

            frmOutRaw winInRaw = new frmOutRaw("Salida de Materia Prima Ventas MP", "S019");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void devPS21_Click(object sender, EventArgs e)
        {
            this.Close();

            frmOutRaw winInRaw = new frmOutRaw("Salida de Materia Prima Devolución Proveedor", "S021");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void reqDMTH1_Click(object sender, EventArgs e)
        {
            this.Close();

            frmOutRaw winInRaw = new frmOutRaw("Salida de Materia Prima DMT - Dep Ind", "H001");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void reqMWH3_Click(object sender, EventArgs e)
        {
            this.Close();

            frmOutRaw winInRaw = new frmOutRaw("Salida de Materia Prima MW - Dep Ind", "H003");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void reqFH7_Click(object sender, EventArgs e)
        {
            this.Close();

            frmOutRaw winInRaw = new frmOutRaw("Salida de Materia Prima Formulaciones - Dep Ind", "H007");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void transCH6_Click(object sender, EventArgs e)
        {
            this.Close();

            frmOutRaw winInRaw = new frmOutRaw("Salida de Materia Prima Calderón - Dep Ind", "H006");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        #endregion

        #region Return

        private void generateButtonReturn()
        {
            pnlReturn.BringToFront();
            pnlReturn.Show();
            this.Height = 329;
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            this.Close();

            frmReRaw winInRaw = new frmReRaw("Devolución de Materia Prima DMT - Consumo", "E2");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void btnE35_Click(object sender, EventArgs e)
        {
            this.Close();

            frmReRaw winInRaw = new frmReRaw("Devolución de Materia Prima MW - Consumo", "E35");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void btnE30_Click(object sender, EventArgs e)
        {
            this.Close();

            frmReRaw winInRaw = new frmReRaw("Devolución de Materia Prima Formulados - Consumo", "E30");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void btnE33_Click(object sender, EventArgs e)
        {
            this.Close();

            frmReRaw winInRaw = new frmReRaw("Devolución de Materia Prima DMT - Dep Ind", "E33");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        private void btnE36_Click(object sender, EventArgs e)
        {
            this.Close();

            frmReRaw winInRaw = new frmReRaw("Devolución de Materia Prima MW - Dep Ind", "E36");
            winInRaw.MdiParent = frmMain;
            winInRaw.StartPosition = FormStartPosition.CenterScreen;
            winInRaw.WindowState = FormWindowState.Maximized;
            winInRaw.Show();
        }

        #endregion

        #region Process Return

        private void btnProcessR_Click(object sender, EventArgs e)
        {
            this.Close();

            frmReProRaw winInRaw = new frmReProRaw("E36");

            if (winInRaw.isAutoricet)
            {
                winInRaw.MdiParent = frmMain;
                winInRaw.StartPosition = FormStartPosition.CenterScreen;
                winInRaw.WindowState = FormWindowState.Maximized;
                winInRaw.Show();
            }
        }

        #endregion

    }
}
