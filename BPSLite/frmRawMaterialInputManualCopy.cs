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
    public partial class frmRawMaterialInputManualCopy : Form
    {

        // Aca dejo todas las Listas que necesito
        List<clsRawMaterial> listaRawMats = new List<clsRawMaterial>();
        List<clsCoilCellar> listaBodegasRaw = new List<clsCoilCellar>();

        //Aca todos los objetos que se van a usar a nivel global en el formulario
        clsRawMaterial rawMaterial = new clsRawMaterial();
        clsRawMaterial rawMaterialSilo = new clsRawMaterial();

        public frmRawMaterialInputManualCopy()
        {
            InitializeComponent();
            cargarCombos();
        }

        private void cargarCombos()
        {
            listaRawMats = clsRawMaterial.getListRaw();
            listaBodegasRaw = clsCoilCellar.lstRawCellar();

            for (int i = 0; i < listaRawMats.Count; i++)
            {
                cmbCodPallet.Items.Add(listaRawMats[i].code);
                cmbCodSilo.Items.Add(listaRawMats[i].code);
            }

            for (int i = 0; i < listaBodegasRaw.Count; i++)
            {
                cmbBodegaPallets.Items.Add(listaBodegasRaw[i].name);
                cmbDestinoSilo.Items.Add(listaBodegasRaw[i].name);
            }
        }

        #region Solapa Pallets
        private void cmbCodPallet_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rawMaterial = clsRawMaterial.getObjByCode(cmbCodPallet.SelectedItem.ToString());
            txtNomMatPallet.Text = rawMaterial.name;
            txtProveedorPallet.Text = new clsEntity(rawMaterial.fkEntity).companyName;
            txtTipoMatPallet.Text = new clsRawMaterialtype(rawMaterial.fkRawMaterialtype).name;
        }
        

        private void btnGuardarPallet_Click(object sender, EventArgs e)
        {
            if (txtCantKilosPallet.Text != string.Empty)
            {
                if (txtCantidadPalletPallets.Text != string.Empty)
                {
                    if (txtLotePallet.Text != string.Empty && cmbBodegaPallets.SelectedIndex != -1)
                    {
                        for (int i = 0; i < Convert.ToInt32(txtCantidadPalletPallets.Text);i++ )
                        {
                            clsRawMaterialMovements movimientosRaw = new clsRawMaterialMovements();
                            clsRawMaterialPallet palletRawMat = new clsRawMaterialPallet();

                            movimientosRaw.fkRaw = rawMaterial.codsec;
                            movimientosRaw.type = "Ingreso de Materias Prima Manual";

                        }
                       
                    }
                    else
                    {
                        txtLotePallet.BackColor = Color.Red;
                    }
                }
                else
                {
                    txtCantidadPalletPallets.BackColor = Color.Red;
                }
            }
            else
            {
                txtCantKilosPallet.BackColor = Color.Red;

            }
        }
        #endregion
    }
}
