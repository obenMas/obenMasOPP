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

namespace BPS
{
    public partial class Romaneo : Form
    {
        public Romaneo()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count>0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                sfd.FileName = textBox1.Text;

                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    StreamWriter writer = new StreamWriter(sfd.OpenFile());

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {

                        writer.WriteLine(dataGridView1.Rows[i].Cells[Datos.Index].Value.ToString());

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
                DataSet DS = clsConnection.getDataSetResult("CALL spRomaneo("+textBox1.Text+")");

                dataGridView1.Rows.Clear();

                if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
                {
                    for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Datos.Index].Value = DS.Tables[0].Rows[i]["Result"];
                    }
                }
                else
                {
                    MessageBox.Show("No hay datos para ese numero de predespacho.", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet DS = clsConnection.getDataSetResult("CALL spRomaneo(" + textBox1.Text + ")");

            dataGridView1.Rows.Clear();

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Datos.Index].Value = DS.Tables[0].Rows[i]["Result"];
                }
            }
            else
            {
                MessageBox.Show("No hay datos para ese numero de predespacho.", "Error", MessageBoxButtons.OK);
            }
        }
        
    }
}
