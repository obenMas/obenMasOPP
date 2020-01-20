using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace BPS.Lite
{
    public partial class Romaneo : Form
    {
        public Romaneo()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(dgvViejo.Rows.Count>0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.FileName = txtAgregadosViejo.Text;

                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    StreamWriter writer = new StreamWriter(sfd.OpenFile());

                    for (int i = 0; i < dgvViejo.Rows.Count; i++)
                    {

                        writer.WriteLine(dgvViejo.Rows[i].Cells[Datos.Index].Value.ToString());

                    }

                    writer.Dispose();

                    writer.Close();

                }

                MessageBox.Show("Archivo generado correctamente.", "Exito", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No hay datos.", "Error", MessageBoxButtons.OK);
            }
            

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                DataSet DS = clsConnection.getDataSetResult("CALL spRomaneo(" + txtPDViejo.Text + ")");

                //dataGridView1.Rows.Clear();

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    if (txtAgregadosViejo.Text == string.Empty)
                    {
                        txtAgregadosViejo.Text = txtPDViejo.Text;
                    }
                    else
                    {
                        txtAgregadosViejo.Text = txtAgregadosViejo.Text + " - " + txtPDViejo.Text;
                    }

                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvViejo.Rows.Add();
                        dgvViejo.Rows[dgvViejo.Rows.Count - 1].Cells[Datos.Index].Value = DS.Tables[0].Rows[i]["Result"];
                    }
                    txtPDViejo.Clear();
                    txtPDViejo.Focus();
                }
                else
                {
                    MessageBox.Show("No hay datos para ese numero de predespacho.", "Error", MessageBoxButtons.OK);
                    txtPDViejo.Clear();
                    txtPDViejo.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet DS = clsConnection.getDataSetResult("CALL spRomaneo(" + txtPDViejo.Text + ")");

            //dataGridView1.Rows.Clear();

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                if(txtAgregadosViejo.Text==string.Empty)
                {
                    txtAgregadosViejo.Text = txtPDViejo.Text;
                }
                else
                {
                    txtAgregadosViejo.Text = txtAgregadosViejo.Text + " - " + txtPDViejo.Text;
                }
                
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvViejo.Rows.Add();
                    dgvViejo.Rows[dgvViejo.Rows.Count - 1].Cells[Datos.Index].Value = DS.Tables[0].Rows[i]["Result"];
                }
                txtPDViejo.Clear();
                txtPDViejo.Focus();
            }
            else
            {
                MessageBox.Show("No hay datos para ese numero de predespacho.", "Error", MessageBoxButtons.OK);
                txtPDViejo.Clear();
                txtPDViejo.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvViejo.Rows.Clear();
            txtAgregadosViejo.Clear();
            txtPDViejo.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSet DS = clsConnection.getDataSetResult("CALL spNuevoRomaneo('" + txtPDViejo.Text + "')");

            //dataGridView1.Rows.Clear();

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                if (txtAgregadosNuevo.Text == string.Empty)
                {
                    txtAgregadosNuevo.Text = txtPDNuevo.Text;
                }
                else
                {
                    txtAgregadosNuevo.Text = txtAgregadosNuevo.Text + " - " + txtPDNuevo.Text;
                }

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvNuevo.Rows.Add();
                    dgvNuevo.Rows[dgvNuevo.Rows.Count - 1].Cells[Datos.Index].Value = DS.Tables[0].Rows[i]["Result"];
                }
                txtPDNuevo.Clear();
                txtPDNuevo.Focus();
            }
            else
            {
                MessageBox.Show("No hay datos para ese numero de predespacho.", "Error", MessageBoxButtons.OK);
                txtPDNuevo.Clear();
                txtPDNuevo.Focus();
            }
        }

        private void btnLimpiarNuevo_Click(object sender, EventArgs e)
        {
            dgvNuevo.Rows.Clear();
            txtAgregadosNuevo.Clear();
            txtPDNuevo.Focus();
        }

        private void btnExportarNuevo_Click(object sender, EventArgs e)
        {
            if (dgvNuevo.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.FileName = txtAgregadosNuevo.Text;

                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    StreamWriter writer = new StreamWriter(sfd.OpenFile());

                    for (int i = 0; i < dgvNuevo.Rows.Count; i++)
                    {

                        writer.WriteLine(dgvNuevo.Rows[i].Cells[Datos.Index].Value.ToString());

                    }

                    writer.Dispose();

                    writer.Close();

                }

                MessageBox.Show("Archivo generado correctamente.", "Exito", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No hay datos.", "Error", MessageBoxButtons.OK);
            }
        }

        private void txtPDNuevo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataSet DS = clsConnection.getDataSetResult("CALL spNuevoRomaneo('" + txtPDNuevo.Text + "')");

                //dataGridView1.Rows.Clear();

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    if (txtAgregadosNuevo.Text == string.Empty)
                    {
                        txtAgregadosNuevo.Text = txtPDNuevo.Text;
                    }
                    else
                    {
                        txtAgregadosNuevo.Text = txtAgregadosNuevo.Text + " - " + txtPDNuevo.Text;
                    }

                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvNuevo.Rows.Add();
                        dgvNuevo.Rows[dgvNuevo.Rows.Count - 1].Cells[Datos.Index].Value = DS.Tables[0].Rows[i]["Result"];
                    }
                    txtPDNuevo.Clear();
                    txtPDNuevo.Focus();
                }
                else
                {
                    MessageBox.Show("No hay datos para ese numero de predespacho.", "Error", MessageBoxButtons.OK);
                    txtPDNuevo.Clear();
                    txtPDNuevo.Focus();
                }
            }
        }
        
    }
}
