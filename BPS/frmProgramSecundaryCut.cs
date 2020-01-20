using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;


namespace BPS
{
    public partial class frmProgramSecundaryCut : Form
    {

        frmCuttingOrderMultiple prnCuttingOrderMultiple;
        int boppFilmSelected = 0;
        DataSet DS = new DataSet();
        clsProduct producto = new clsProduct();

        public frmProgramSecundaryCut()
        {
            InitializeComponent();
        }

        public frmProgramSecundaryCut(frmCuttingOrderMultiple winCuttingOrderMultiple, int boppFilmCodsec,string lblFilmName)
        {
            InitializeComponent();

            lblPelicula.Text = lblFilmName;

            this.prnCuttingOrderMultiple = winCuttingOrderMultiple;
            this.boppFilmSelected = boppFilmCodsec;

            if (boppFilmSelected != 0)
            {
                string texto = "CALL spBoppByFilmCodsecAndWidth(" + boppFilmSelected.ToString() + "," + "'%')";

                DS = clsConnection.getDataSetResult(texto);
            }

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvProducts.Rows.Add();
                    dgvProducts.Rows[dgvProducts.Rows.Count - 1].Cells[clmAncho.Index].Value = DS.Tables[0].Rows[i]["ancho"].ToString();
                    dgvProducts.Rows[dgvProducts.Rows.Count - 1].Cells[clmCodigo.Index].Value = DS.Tables[0].Rows[i]["Codigo"].ToString();
                    dgvProducts.Rows[dgvProducts.Rows.Count - 1].Cells[clmNombre.Index].Value = DS.Tables[0].Rows[i]["nombre"].ToString();
                    dgvProducts.Rows[dgvProducts.Rows.Count - 1].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["pelicula"].ToString();
                    dgvProducts.Rows[dgvProducts.Rows.Count - 1].Cells[clmCodsec.Index].Value = DS.Tables[0].Rows[i]["codsec"].ToString();
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtCantidad.Text != string.Empty)
            {
                if (dgvProducts.CurrentRow != null)
                {
                    string producto2 = dgvProducts.CurrentRow.Cells[clmCodigo.Index].Value.ToString();
                    producto = new clsProduct(dgvProducts.CurrentRow.Cells[clmCodigo.Index].Value.ToString());

                    prnCuttingOrderMultiple.selectedProductCodsec = producto.codsec;
                    prnCuttingOrderMultiple.cantidad = Convert.ToInt32(txtCantidad.Text);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seleccione algun producto de la tabla","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Question);
                }
            }
            else
            {
                MessageBox.Show("Por favor complete la cantidad a programar.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void txtAncho_TextChanged(object sender, EventArgs e)
        {
            if (boppFilmSelected != 0)
            {
                DS = clsConnection.getDataSetResult("CALL spBoppByFilmCodsecAndWidth(" + boppFilmSelected.ToString() + ",'" + txtAncho.Text + "%')");
            }

            dgvProducts.Rows.Clear();

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvProducts.Rows.Add();
                    dgvProducts.Rows[dgvProducts.Rows.Count - 1].Cells[clmAncho.Index].Value = DS.Tables[0].Rows[i]["ancho"].ToString();
                    dgvProducts.Rows[dgvProducts.Rows.Count - 1].Cells[clmCodigo.Index].Value = DS.Tables[0].Rows[i]["Codigo"].ToString();
                    dgvProducts.Rows[dgvProducts.Rows.Count - 1].Cells[clmNombre.Index].Value = DS.Tables[0].Rows[i]["nombre"].ToString();
                    dgvProducts.Rows[dgvProducts.Rows.Count - 1].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["pelicula"].ToString();
                    dgvProducts.Rows[dgvProducts.Rows.Count - 1].Cells[clmCodsec.Index].Value = DS.Tables[0].Rows[i]["codsec"].ToString();
                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAncho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
