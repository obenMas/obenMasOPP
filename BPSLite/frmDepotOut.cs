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
    public partial class frmDepotOut : Form
    {
        clsCoilCellar destinationCellar = new clsCoilCellar();
        clsPallet pallet = new clsPallet();

        public frmDepotOut()
        {
            InitializeComponent();
            txtPallet.Focus();
        }

        private void txtPallet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (validateOut())
                {
                    dgvDepotOut.Rows.Add();
                    dgvDepotOut.Rows[dgvDepotOut.Rows.Count - 1].Cells[clmCodsec.Index].Value = pallet.codsec;
                    dgvDepotOut.Rows[dgvDepotOut.Rows.Count - 1].Cells[clmCode.Index].Value = pallet.code;
                    dgvDepotOut.Rows[dgvDepotOut.Rows.Count - 1].Cells[clmNetWeigth.Index].Value = Math.Round(pallet.netWeight,2);
                    dgvDepotOut.Rows[dgvDepotOut.Rows.Count - 1].Cells[clmGrossWeigth.Index].Value = pallet.grossWeight;
                    dgvDepotOut.Rows[dgvDepotOut.Rows.Count - 1].Cells[clmfkCoilCellar.Index].Value = destinationCellar.codsec;
                    dgvDepotOut.Rows[dgvDepotOut.Rows.Count - 1].Cells[clmCellar.Index].Value = destinationCellar.name;
                    dgvDepotOut.Rows[dgvDepotOut.Rows.Count - 1].Cells[clmDelete.Index].Value = BPS.Lite.Properties.Resources.cross;
                }
                txtPallet.ResetText();
                txtPallet.Focus();
            }
        }


         public bool validateOut()
        {
            bool ret = false;
            pallet = clsPallet.getDetailByCode(txtPallet.Text);
            clsCoilCellar cellar = new clsCoilCellar(pallet.fkPalletCoilcellar);
            //List<clsCoil> list = clsCoil.getCoilListByPallet(pallet.codsec);

            //Obtengo el destino (Bodega "Producto en Proceso")
            destinationCellar = getDestinationCellar();
            
             switch(pallet.fkPalletCoilcellar)
             {
                 case 1011:
                     ret = true;
                     break;

                 case 3012:
                     ret = true;
                     break;

                 case 2011:
                     ret = true;
                     break;

                 default :
                     ret = false;
                     MessageBox.Show("El pallet no se encuentra en la bodega.", "Error en egreso", MessageBoxButtons.OK);
                     break;
             }

             //Valida que no haya pallet duplicado en el DGV
            for (int j = 0; j < dgvDepotOut.Rows.Count; j++)
            {
                if (pallet.code == dgvDepotOut.Rows[j].Cells[clmCode.Index].Value.ToString())
                {
                    ret = false;
                    MessageBox.Show("El pallet no se puede ingresar porque ya se encuentra en la lista de pallets a ingresar.", "Error en ingreso", MessageBoxButtons.OK);
                }
            }
            return ret;

        }


        public clsCoilCellar getDestinationCellar( )
        {
            clsCoilCellar cellar = new clsCoilCellar();

            cellar = clsCoilCellar.getCellarByName("Producto en Proceso");

            return cellar;
         }


         private void dgvDepotOut_CellClick(object sender, DataGridViewCellEventArgs e)
         {
             if (e.ColumnIndex == clmDelete.Index)
             {
                 dgvDepotOut.Rows.RemoveAt(e.RowIndex);
             }
         }

         private void btnOut_Click(object sender, EventArgs e)
         {
             for (int i = 0; i < dgvDepotOut.Rows.Count; i++)
             {
                 pallet = new clsPallet(Convert.ToInt32(dgvDepotOut.Rows[i].Cells[clmCodsec.Index].Value));
                 clsPallet.transferTo(pallet, Convert.ToInt32(dgvDepotOut.Rows[i].Cells[clmfkCoilCellar.Index].Value));
                 pallet.position = "0";
                 pallet.updatePosition("0"); 
             }

             MessageBox.Show("Se procesaron todos los movimientos.", "Egreso de bodega", MessageBoxButtons.OK);
             txtPallet.ResetText();
             dgvDepotOut.Rows.Clear();
             txtPallet.Focus();
         }

    }
}
