using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmImportRawMaterialGranel : Form
    {
        public frmImportRawMaterialGranel(string codigo, string cantidad, string partida, string proveedor, string nombreempresa)
        {
            InitializeComponent();

            txtCodigo.Text = codigo;
            txtCantidad.Text = Convert.ToString(cantidad);
            txtPartidas.Text = partida;
            txtProveedor.Text = Convert.ToString(proveedor);
            txtEmpresa.Text = nombreempresa;

            List<clsCoilCellar> silos = new List<clsCoilCellar>();
            silos = clsCoilCellar.lstSiloCellar();

            for (int i = 0; i < silos.Count; i++)
            {
                cmbBodegas.Items.Add(silos[i]);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //Esta hecho de una manera muy ñeri. Como poder pueden cargar mas de una cosa.
            if (txtCantidad.Text != "" && cmbBodegas.SelectedIndex != -1 && txtLote.Text != "")
            {
                if (dgvImportRawMat.Rows.Count <= 0)
                {
                    dgvImportRawMat.Rows.Add();
                    dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmCodigo.Index].Value = Convert.ToString(txtCodigo.Text);
                    dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmCantidad.Index].Value = txtCantidad.Text;
                    dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmLote.Index].Value = txtLote.Text.ToUpper();
                    dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmEmpresa.Index].Value = txtEmpresa.Text;
                    dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmNotas.Index].Value = txtNotas.Text;
                    dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmProveedor.Index].Value = txtProveedor.Text;
                    dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmSilo.Index].Value = cmbBodegas.SelectedItem.ToString();
                    dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmFecha.Index].Value = DateTime.Now;
                }  
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Esto es lo peor, esta tomando todo de los txt y los cmb, esto no se hace.

            if (txtCantidad.Text != "" && cmbBodegas.SelectedIndex != -1 && txtLote.Text != "")
            {
                bool anduvo;
                clsCoilCellar siloCellar = new clsCoilCellar(cmbBodegas.Text);
                clsRawMaterialBySiloCellar silo = new clsRawMaterialBySiloCellar();
                clsRawMaterial material = new clsRawMaterial();
                material = clsRawMaterial.getObjByCode(txtCodigo.Text);
                anduvo = silo.checkSiloItsGood(Convert.ToInt32(siloCellar.codsec), Convert.ToInt32(material.codsec), Convert.ToInt32(material.fkRawMaterialtype), Convert.ToString(txtLote.Text), Convert.ToDouble(txtCantidad.Text));

                if (anduvo == true)
                {
                    MessageBox.Show("Datos procesados correctamente", "¡Exito!", MessageBoxButtons.OK);
                    dgvImportRawMat.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("El Material que intenta ingresar, no se puede mezclar con el contenido del Silo.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    dgvImportRawMat.Rows.Clear();
                }
            }
        }
    }
}
