using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BPS.Bussiness;
using System.Data;

namespace ConsoleApplication3
{
    public partial class frmPruebas : Form
    {
        DataSet DS = new DataSet();
        int count = 0;
        List<String> lista = new List<string>();
        string mensaje;

        public frmPruebas()
        {
            InitializeComponent();
            //DS = clsConnection.getDataSetResult("SELECT TOP 10 * FROM bps_prod_rawmaterialbysilocellar WHERE rwmbsc_fkSiloCellar = 4025");
            /*lista.Add("Tu vieja");
            lista.Add("Tu otra vieja");
            lista.Add("Tu her");
            lista.Add("Tuja");
            lista.Add("Tupri");
            lista.Add("Tupa");

            for (int i = 0; i < lista.Count; i++)
            {
                mensaje = mensaje + lista[i] + " \n";
            }


            MessageBox.Show("Estoy mostrando la lista de: " + mensaje, "Tuja", MessageBoxButtons.OK);*/
        }

        private void probando()
        {
            /*lbl2.Text = DS.Tables[0].Rows.Count.ToString();  Lo que hace este algoritmo es agregarle una coluna temporal al DataSet llamada EStado
             * A medida que la labura, le va cambiando el estado. Entonces te permite llevar un control mas mejor en tiempo de ejecucion. 

            DataColumn DC = DS.Tables[0].Columns.Add("Estado", typeof(string), "38");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                if (DS.Tables[0].Rows[i]["rwmbsc_lote"].ToString() == txtLote.Text)
                {
                    //DS.Tables[0].Rows.Remove(row:this.DS.Tables[0].Rows[i]);
                    DS.Tables[0].Rows[i]["Estado"] = "41";
                    count++;
                }
                lbl1.Text = count.ToString();
            }*/



            if (txtLote.Text.Contains("Cancelar"))
            {
                txtLote.Text = string.Empty;
            }
            else
            {
                txtLote.Text = "Esto no anda carlos.";
            }
        }

        private void txtLote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                probando();
            }
        }

        private void txtLote_TextChanged(object sender, EventArgs e)
        {
            int boppCoil = clsBopp.getFilmByCode(txtPeli.Text);
            int castCoil = clsCast.getFilmByCode(txtPeli.Text);
            int coatingCoil = clsCoating.getFlmByCode(txtPeli.Text);
            DataSet DS = new DataSet();

            if (boppCoil != 0)
            {
                DS = clsConnection.getDataSetResult("CALL procedure2(" + boppCoil.ToString() + "," + castCoil.ToString() + "," + coatingCoil.ToString() + ",'" + txtLote.Text + "%')");
            }
            else if (castCoil != 0)
            {
                DS = clsConnection.getDataSetResult("CALL procedure2(" + boppCoil.ToString() + "," + castCoil.ToString() + "," + coatingCoil.ToString() + ",'" + txtLote.Text + "%')");
            }
            else if (coatingCoil != 0)
            {
                DS = clsConnection.getDataSetResult("CALL procedure2(" + boppCoil.ToString() + "," + castCoil.ToString() + "," + coatingCoil.ToString() + ",'" + txtLote.Text + "%')");
            }

            dgvPrueba.Rows.Clear();

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvPrueba.Rows.Add();
                    dgvPrueba.Rows[dgvPrueba.Rows.Count - 1].Cells[clmCodigo.Index].Value = DS.Tables[0].Rows[i]["Codigo"].ToString();
                    dgvPrueba.Rows[dgvPrueba.Rows.Count - 1].Cells[clmNombre.Index].Value = DS.Tables[0].Rows[i]["nombre"].ToString();
                    dgvPrueba.Rows[dgvPrueba.Rows.Count - 1].Cells[clmAncho.Index].Value = DS.Tables[0].Rows[i]["ancho"].ToString();
                    dgvPrueba.Rows[dgvPrueba.Rows.Count - 1].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["pelicula"].ToString();
                }
            }
        }

        private void dgvPrueba_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmAd.Index)
            {
                frmAddTuja tuja = new frmAddTuja(dgvPrueba);
                tuja.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddTuja tuja = new frmAddTuja(dgvPrueba);
            tuja.ShowDialog();
        }
    }
}
