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
    public partial class frmPalletDimentions : Form
    {
        public frmPalletDimentions()
        {
            InitializeComponent();
        }

        private void nmupdwWidth_ValueChanged(object sender, EventArgs e)
        {
            lblResultDimensions.Text = nmupdwWidth.Value.ToString();
        }

        private void nmupdwDepth_ValueChanged(object sender, EventArgs e)
        {
            lblResultDimensions.Text = nmupdwWidth.Value.ToString() + " X " + nmupdwDepth.Value.ToString();
        }

        private void btnAddDimension_Click(object sender, EventArgs e)
        {
            if (nmupdwWidth.Value != 0 || nmupdwDepth.Value != 0)
            {
                if ((MessageBox.Show("Está seguro de agregar dimensiones de "+lblResultDimensions.Text+" ","Dimensiones",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    clsPalletDimentions ObjPalletDimentions = new clsPalletDimentions();
                    ObjPalletDimentions.width = Convert.ToInt32(nmupdwWidth.Value);
                    ObjPalletDimentions.depth = Convert.ToInt32(nmupdwDepth.Value);
                    if (ObjPalletDimentions.save())
                    {
                        MessageBox.Show("Dimensión agregda correctamente", "Dimensiones", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("A sucedido un error inesperado", "Dimensiones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
	            {
                    this.Close();
	            }
            }
            else
            {
                MessageBox.Show("Debe asignar valores diferentes de 0 ", "Dimensiones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
