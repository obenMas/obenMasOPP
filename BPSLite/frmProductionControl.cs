using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BPS.Lite
{
    public partial class frmProductionControl : Form
    {
        private int segundos = 0;
        private int minutos = 0;
        private int horas = 0;
        private bool actualizarTiempo = true;

        public frmProductionControl()
        {
            InitializeComponent();
            lblActividad.Text = "Máquina Parada";
            dgvActividadesRealizadas.Rows.Add();
            reiniciarTiempo();            
            dgvActividadesRealizadas.Rows[dgvActividadesRealizadas.Rows.Count - 1].Cells[actividad.Index].Value = "Máquina Parada";
            dgvActividadesRealizadas.Rows[dgvActividadesRealizadas.Rows.Count - 1].Cells[detalle.Index].Value = "Sin orden de producción";
        }

        private void cerrarActividad(string nuevaActividad, string nuevoDetalle)
        {
            dgvActividadesRealizadas.Rows[dgvActividadesRealizadas.Rows.Count - 1].Cells[hasta.Index].Value = DateTime.Now.ToString();
            dgvActividadesRealizadas.Rows.Add();
            dgvActividadesRealizadas.Rows[dgvActividadesRealizadas.Rows.Count - 1].Cells[actividad.Index].Value = nuevaActividad;
            dgvActividadesRealizadas.Rows[dgvActividadesRealizadas.Rows.Count - 1].Cells[detalle.Index].Value = nuevoDetalle;
        }

        private void btnPreparacion_Click(object sender, EventArgs e)
        {
            cerrarActividad("Preparación","Preparación");
            grbActividadActual.BackColor = btnPreparacion.BackColor;
            lblActividad.Text = "Preparación";
            reiniciarTiempo();
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            cerrarActividad("Producción","");
            grbActividadActual.BackColor = btnProduccion.BackColor;
            lblActividad.Text = "Producción";
            reiniciarTiempo();
        }

        private void btnMaquinaParada_Click(object sender, EventArgs e)
        {
            cerrarActividad("Máquina Parada", "Sin orden de producción");
            grbActividadActual.BackColor = btnMaquinaParada.BackColor;
            lblActividad.Text = "Máquina Parada";
            reiniciarTiempo();
        }

        private void actulizarTiempoTranscurrido()
        {
            if(actualizarTiempo)
            {
                if(dgvActividadesRealizadas.Rows.Count>0)
                {
                    DateTime inicio = Convert.ToDateTime(dgvActividadesRealizadas.Rows[dgvActividadesRealizadas.Rows.Count - 1].Cells[desde.Index].Value);
                    TimeSpan diferencia = DateTime.Now.Subtract(inicio);
                    segundos = diferencia.Seconds % 60;
                    minutos = diferencia.Minutes % 60;
                    horas = diferencia.Hours;
                }

                if(segundos<10)
                {
                    txtSegundos.Text = "0"+segundos.ToString();
                }
                else
                {
                    txtSegundos.Text = segundos.ToString();
                }
                
                if(minutos<10)
                {
                    txtMinutos.Text = "0"+minutos.ToString();
                }
                else
                {
                    txtMinutos.Text = minutos.ToString();
                }

                if(horas<10)
                {
                    txtHoras.Text = "0"+horas.ToString();
                }
                else
                {
                    txtHoras.Text = horas.ToString();
                }              
            }
        }

        private void reiniciarTiempo()
        {
            segundos = 0;
            minutos = 0;
            horas = 0;
            dgvActividadesRealizadas.Rows[dgvActividadesRealizadas.Rows.Count - 1].Cells[desde.Index].Value = DateTime.Now.ToString();
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            actulizarTiempoTranscurrido();
        }

    }
}
