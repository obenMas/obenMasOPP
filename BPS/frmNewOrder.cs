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
    public partial class frmNewOrder : Form
    {
        public frmNewOrder()
        {
            InitializeComponent();
        }

        private void frmNewOrder_Load(object sender, EventArgs e)
        {
            List<clsBopp> lstBopp = clsBopp.getSimplifiedList();
            cmbPelicula.Items.Clear();
            for (int i = 0; i < lstBopp.Count; i++)
                cmbPelicula.Items.Add(lstBopp[i]);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            if (cmbPelicula.SelectedIndex != -1)
            {
                clsProductionOrder ProductionOrder = new clsProductionOrder();
                ProductionOrder.fkBopp = ((clsBopp)cmbPelicula.SelectedItem).codsec;
                ProductionOrder.fkBoppOriginal = ((clsBopp)cmbPelicula.SelectedItem).codsec;
                ProductionOrder.fkThermoformed = 0;
                ProductionOrder.fkReprocessed = 0;
                ProductionOrder.fkStatus = 17;
                ProductionOrder.number = 0;
                ProductionOrder.quantity = Convert.ToDouble(txtPeso.Text);
                ProductionOrder.inheritedFrom = 0;
                ProductionOrder.closeObservation = "";
                if(ProductionOrder.save())
                {
                    MessageBox.Show("Nueva orden creada con exito!", "Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Error al guardar la orden", "Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbPelicula.SelectedIndex == -1)
                MessageBox.Show("Por favor seleccione una pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtPeso.Text=="0")
                MessageBox.Show("El peso debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtPeso_Validating(object sender, CancelEventArgs e)
        {
            if (clsGlobal.isNumeric(txtPeso.Text) == false && txtPeso.Text!= "")
            {
                MessageBox.Show("El valor debe ser Numérico");
                txtPeso.Text = "0";
            }
        }

        private void txtPeso_Click(object sender, EventArgs e)
        {
            txtPeso.SelectAll();
        }
    }
}
