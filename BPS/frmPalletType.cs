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
    public partial class frmPalletType : Form
    {
        int floor, coil;
        public frmPalletType()
        {
            InitializeComponent();
        }

        private void txtnumbercoilbystop_TextChanged(object sender, EventArgs e)
        {
            
            if (txtnumbercoilbystop.Text == "" || txtnumbercoilbystop.Text.Length == 0)
            {
                txtnumbercoilbystop.Text = "0";
                coil = 0;
            }
            else
            {coil = Convert.ToInt32(txtnumbercoilbystop.Text);}
            lblresultpallet.Text = "Pallet " + ((coil == 1) ? (coil.ToString() + " Bobina ") : (coil.ToString() + " Bobinas "));
        }

        private void cbotraining_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblresultpallet.Text = "Pallet " + ((coil == 1) ? (coil.ToString() + " Bobina ") : (coil.ToString() + " Bobinas ")) + cbotraining.SelectedItem;
        }

        private void cboFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            floor = Convert.ToInt32(cboFloor.SelectedItem);
            lblresultpallet.Text = "Pallet " + ((coil == 1) ? (coil.ToString() + " Bobina ") : (coil.ToString() + " Bobinas ")) + cbotraining.SelectedItem + " " + ((floor == 1) ? (floor.ToString() + " Piso") : (floor.ToString() + " Pisos"));
        }

        private void btnAddPallet_Click(object sender, EventArgs e)
        {

            if (txtnumbercoilbystop.Text != "" || txtnumbercoilbystop.Text.Length != 0 || cbotraining.SelectedItem != null || cboFloor.SelectedValue != null)
            {
                if (MessageBox.Show("Esta seguro de agregar pallet?", "Pallet", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    clsPalletType ObjPallet = new clsPalletType();
                    ObjPallet.coilNumber = Convert.ToInt32(txtnumbercoilbystop.Text);
                    ObjPallet.coilOrientation = cbotraining.SelectedItem.ToString();
                    ObjPallet.floors = Convert.ToInt32(cboFloor.SelectedItem);
                    ObjPallet.name = lblresultpallet.Text;
                    ObjPallet.code = txtCode.Text;
                    if (ObjPallet.save())
                    {
                        MessageBox.Show("Ingreso exitoso de pallet", "Pallet", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("A sucedido un error inesperado", "Pallet", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Debe selecionar los datos requeridos!!", "Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
