using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace BPS.Lite
{
    public partial class PruebaMail : Form
    {
        public PruebaMail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SmtpClient cliente = new SmtpClient())
            {
                cliente.Host = "smtp.gmail.com";
                cliente.Port = 587;
                cliente.EnableSsl = true;

                cliente.Credentials = new NetworkCredential("reporteopp@gmail.com","jozONZ0826");
                MailMessage mensaje = new MailMessage("reporteopp@gmail.com","nahuel.zarate@gmail.com","Prueba Mail","Prueba mail por c#");

                try
                {
                    cliente.Send(mensaje);
                    MessageBox.Show("Correo enviado");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


    }
}
