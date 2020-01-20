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
    public partial class frmDateSelector : Form
    {
        frmNewExtrusionOrder form;
        public frmDateSelector(frmNewExtrusionOrder frm)
        {
            InitializeComponent();
            form = frm;
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss"); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime hora= new DateTime();
            try
            {
                hora = Convert.ToDateTime(txtHora.Text);
                if (hora.Hour < 24 && hora.Minute < 60 && hora.Second < 60)
                {
                    DateTime fecha = new DateTime(mtCalendario.SelectionStart.Year, mtCalendario.SelectionStart.Month, mtCalendario.SelectionStart.Day, hora.Hour, hora.Minute, hora.Second);
                    form.nuevafechainicio = fecha;
                    MessageBox.Show("Es posible que el proceso dure unos minutos, gracias por su paciencia","Cargando...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Ingrese una hora correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("El formato debe ser 24 horas, separando horas, minutos y segundos con ':'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
