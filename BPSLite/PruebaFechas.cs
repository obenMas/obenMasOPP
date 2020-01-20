using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace BPS.Lite
{
    public partial class PruebaFechas : Form
    {
        public PruebaFechas()
        {
            InitializeComponent();
            cmbMes.SelectedIndex = 0;
            cmbAño.SelectedIndex = 0;
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMes.SelectedIndex!=-1 && cmbAño.SelectedIndex!=-1)
            {
                calcularFechas();
            }
        }

        private void cmbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMes.SelectedIndex != -1 && cmbAño.SelectedIndex != -1)
            {
                calcularFechas();
            }
        }

        private void limpiar()
        {
            txtDesde1.ResetText();
            txtDesde2.ResetText();
            txtDesde3.ResetText();
            txtDesde4.ResetText();
            txtDesde5.ResetText();
            txtDesde6.ResetText();
            txtHasta1.ResetText();
            txtHasta2.ResetText();
            txtHasta3.ResetText();
            txtHasta4.ResetText();
            txtHasta5.ResetText();
            txtHasta6.ResetText();
            txtSemana1.ResetText();
            txtSemana2.ResetText();
            txtSemana3.ResetText();
            txtSemana4.ResetText();
            txtSemana5.ResetText();
            txtSemana6.ResetText();
        }

        private void calcularFechas()
        {
            limpiar();
            DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = info.Calendar;
            txtDesde1.Text = "01/" + cmbMes.Items[cmbMes.SelectedIndex].ToString() + "/" + cmbAño.Items[cmbAño.SelectedIndex].ToString();
            txtSemana1.Text = cal.GetWeekOfYear(Convert.ToDateTime(txtDesde1.Text),info.CalendarWeekRule,info.FirstDayOfWeek).ToString();
        }

        private void txtSemana1_TextChanged(object sender, EventArgs e)
        {
            if(txtSemana1.Text!=string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                DateTime fec = Convert.ToDateTime(txtDesde1.Text);
                int sem = Convert.ToInt32(txtSemana1.Text);
                while (sem == Convert.ToInt32(txtSemana1.Text) && Convert.ToInt32(cmbMes.Items[cmbMes.SelectedIndex]) == fec.Month)
                {
                    fec = fec.AddDays(1);
                    sem = cal.GetWeekOfYear(fec, info.CalendarWeekRule, info.FirstDayOfWeek);
                }
                txtHasta1.Text = fec.AddDays(-1).ToString();
                txtDesde2.Text = fec.ToString();
            }
            
        }

        private void txtDesde2_TextChanged(object sender, EventArgs e)
        {
            if(txtDesde2.Text!=string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                txtSemana2.Text = cal.GetWeekOfYear(Convert.ToDateTime(txtDesde2.Text), info.CalendarWeekRule, info.FirstDayOfWeek).ToString();
            }
        }

        private void txtSemana2_TextChanged(object sender, EventArgs e)
        {
            if(txtSemana2.Text!=string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                DateTime fec = Convert.ToDateTime(txtDesde2.Text);
                int sem = Convert.ToInt32(txtSemana2.Text);
                while (sem == Convert.ToInt32(txtSemana2.Text) && Convert.ToInt32(cmbMes.Items[cmbMes.SelectedIndex]) == fec.Month)
                {
                    fec = fec.AddDays(1);
                    sem = cal.GetWeekOfYear(fec, info.CalendarWeekRule, info.FirstDayOfWeek);
                }
                txtHasta2.Text = fec.AddDays(-1).ToString();
                txtDesde3.Text = fec.ToString();
            }
        }

        private void txtDesde3_TextChanged(object sender, EventArgs e)
        {
            if(txtDesde3.Text!=string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                txtSemana3.Text = cal.GetWeekOfYear(Convert.ToDateTime(txtDesde3.Text), info.CalendarWeekRule, info.FirstDayOfWeek).ToString();
            }
        }

        private void txtSemana3_TextChanged(object sender, EventArgs e)
        {
            if(txtSemana3.Text!=string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                DateTime fec = Convert.ToDateTime(txtDesde3.Text);
                int sem = Convert.ToInt32(txtSemana3.Text);
                while (sem == Convert.ToInt32(txtSemana3.Text) && Convert.ToInt32(cmbMes.Items[cmbMes.SelectedIndex]) == fec.Month)
                {
                    fec = fec.AddDays(1);
                    sem = cal.GetWeekOfYear(fec, info.CalendarWeekRule, info.FirstDayOfWeek);
                }
                txtHasta3.Text = fec.AddDays(-1).ToString();
                txtDesde4.Text = fec.ToString();
            }
        }

        private void txtDesde4_TextChanged(object sender, EventArgs e)
        {
            if(txtDesde4.Text!=string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                txtSemana4.Text = cal.GetWeekOfYear(Convert.ToDateTime(txtDesde4.Text), info.CalendarWeekRule, info.FirstDayOfWeek).ToString();
            }
        }

        private void txtSemana4_TextChanged(object sender, EventArgs e)
        {
            if(txtSemana4.Text!=string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                DateTime fec = Convert.ToDateTime(txtDesde4.Text);
                int sem = Convert.ToInt32(txtSemana4.Text);
                while (sem == Convert.ToInt32(txtSemana4.Text) && Convert.ToInt32(cmbMes.Items[cmbMes.SelectedIndex]) == fec.Month)
                {
                    fec = fec.AddDays(1);
                    sem = cal.GetWeekOfYear(fec, info.CalendarWeekRule, info.FirstDayOfWeek);
                }
                txtHasta4.Text = fec.AddDays(-1).ToString();
                if (Convert.ToInt32(cmbMes.Items[cmbMes.SelectedIndex]) == fec.Month)
                {
                    txtDesde5.Text = fec.ToString();
                }
            }
        }

        private void txtDesde5_TextChanged(object sender, EventArgs e)
        {
            if(txtDesde5.Text!=String.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                txtSemana5.Text = cal.GetWeekOfYear(Convert.ToDateTime(txtDesde5.Text), info.CalendarWeekRule, info.FirstDayOfWeek).ToString();
            }
        }

        private void txtSemana5_TextChanged(object sender, EventArgs e)
        {
            if(txtSemana5.Text!=string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                DateTime fec = Convert.ToDateTime(txtDesde5.Text);
                int sem = Convert.ToInt32(txtSemana5.Text);
                while (sem == Convert.ToInt32(txtSemana5.Text) && Convert.ToInt32(cmbMes.Items[cmbMes.SelectedIndex]) == fec.Month)
                {
                    fec = fec.AddDays(1);
                    sem = cal.GetWeekOfYear(fec, info.CalendarWeekRule, info.FirstDayOfWeek);
                }
                txtHasta5.Text = fec.AddDays(-1).ToString();
                if (Convert.ToInt32(cmbMes.Items[cmbMes.SelectedIndex]) == fec.Month)
                {
                    txtDesde6.Text = fec.ToString();
                }
            }
        }

        private void txtDesde6_TextChanged(object sender, EventArgs e)
        {
            if(txtDesde6.Text!=string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                txtSemana6.Text = cal.GetWeekOfYear(Convert.ToDateTime(txtDesde6.Text), info.CalendarWeekRule, info.FirstDayOfWeek).ToString();
            }
        }

        private void txtSemana6_TextChanged(object sender, EventArgs e)
        {
            if(txtSemana6.Text!=string.Empty)
            {
                DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
                Calendar cal = info.Calendar;
                DateTime fec = Convert.ToDateTime(txtDesde6.Text);
                int sem = Convert.ToInt32(txtSemana6.Text);
                while (sem == Convert.ToInt32(txtSemana6.Text) && Convert.ToInt32(cmbMes.Items[cmbMes.SelectedIndex]) == fec.Month)
                {
                    fec = fec.AddDays(1);
                    sem = cal.GetWeekOfYear(fec, info.CalendarWeekRule, info.FirstDayOfWeek);
                }
                txtHasta6.Text = fec.AddDays(-1).ToString();
            }
        }
    }
}
