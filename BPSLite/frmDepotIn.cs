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
    public partial class frmDepotIn : Form
    {
        clsCoilCellar destinationCellar = new clsCoilCellar();
        clsPallet pallet = new clsPallet();

        public frmDepotIn()
        {
            InitializeComponent();
            cmbMovementType.SelectedIndex = 0;
            txtPallet.Focus();
        }

        private void txtPallet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPallet.Text != "")
                {
                    txtPosition.Focus();
                }
                else
                {
                    MessageBox.Show("Debe ingresar  un pallet.", "Error en ingreso", MessageBoxButtons.OK);          
                }


            }
        }

        private void txtPosition_KeyDown(object sender, KeyEventArgs e)
        {
            pallet = clsPallet.getDetailByCode(txtPallet.Text);
            clsCoilCellar cellarPallet = new clsCoilCellar(pallet.fkPalletCoilcellar);
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPosition.Text != "")
                {
                    if (validateIn())
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmCodsec.Index].Value = pallet.codsec;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmCode.Index].Value = pallet.code;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmNetWeigth.Index].Value =Math.Round(pallet.netWeight,2);
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmGrossWeigth.Index].Value = pallet.grossWeight;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmPosition.Index].Value = txtPosition.Text;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmfkCoilCellar.Index].Value = destinationCellar.codsec;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmCellar.Index].Value = destinationCellar.name;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmDelete.Index].Value = BPS.Lite.Properties.Resources.cross;
                        if (cmbMovementType.SelectedIndex == 2 && cellarPallet.name != "Conversión" )
                        {
                            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmPositionChange.Index].Value = true; 
                        }
                        else
                        {
                            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmPositionChange.Index].Value = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar  una posición.", "Error en ingreso", MessageBoxButtons.OK);
                }
                txtPallet.ResetText();
                txtPosition.ResetText();
              //cmbMovementType.SelectedIndex = 0;
                txtPallet.Focus();
            }
        }

        public bool validateIn()
        {
            bool ret = false;
            pallet = clsPallet.getDetailByCode(txtPallet.Text);
            clsCoilCellar cellar = new clsCoilCellar(pallet.fkPalletCoilcellar);
            List<clsCoil> list = clsCoil.getCoilListByPallet(pallet.codsec);

            int quality = 0;
            bool qualityDif = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (quality == 0)
                {
                    quality = list[i].fkCuttingQuality;
                }
                else
                {
                    if(quality!=list[i].fkCuttingQuality)
                    {
                        qualityDif = true;
                    }
                } 
            }

            if(!qualityDif)
            {
                destinationCellar = getDestinationCellar(quality);

                if(destinationCellar.name!=cellar.name && destinationCellar.name!=string.Empty)
                {
                    ret = true;
                }
                else if(cmbMovementType.SelectedIndex==2)
                {
                    ret = true;
                }
                else
                {
                    MessageBox.Show("El pallet no se puede ingresar porque ya se encuentra en la bodega de destino.", "Error en ingreso", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("El pallet no se puede ingresar porque tiene bobinas con distintas calificaciones de calidad.", "Error en ingreso", MessageBoxButtons.OK);
            }

            for (int j = 0; j < dataGridView1.Rows.Count;j++)
            {
                if(pallet.code==dataGridView1.Rows[j].Cells[clmCode.Index].Value.ToString())
                {
                    ret = false;
                    MessageBox.Show("El pallet no se puede ingresar porque ya se encuentra en la lista de pallets a ingresar.", "Error en ingreso", MessageBoxButtons.OK);
                }
            }

                return ret;
        }

        public clsCoilCellar getDestinationCellar(int quality)
        {
            clsCoilCellar cellar = new clsCoilCellar();
            clsCuttingQuality objQuality = new clsCuttingQuality(quality);
            pallet = clsPallet.getDetailByCode(txtPallet.Text);
            clsCoilCellar cellarPallet = new clsCoilCellar(pallet.fkPalletCoilcellar);


            if(cmbMovementType.SelectedIndex==1)
            {
                cellar = clsCoilCellar.getCellarByName("Producto en Proceso");
            }
            if (cmbMovementType.SelectedIndex == 2 && cellarPallet.name == "Conversión")
            {
                    switch (objQuality.name)
                    {
                        case "Primera":
                            cellar = clsCoilCellar.getCellarByName("Producto Terminado");
                            break;

                        case "Observación":
                            cellar = clsCoilCellar.getCellarByName("Producto en Proceso");
                            break;

                        case "Segunda":
                            cellar = clsCoilCellar.getCellarByName("Producto en Proceso");
                            break;
                    }
            }
            else
            {
                switch (objQuality.name)
                {
                    case "Primera":
                        cellar = clsCoilCellar.getCellarByName("Producto Terminado");
                        break;

                    case "Observación":
                        cellar = clsCoilCellar.getCellarByName("Producto en Proceso");
                        break;

                    case "Segunda":
                        cellar = clsCoilCellar.getCellarByName("Producto en Proceso");
                        break;
                }
            }

            return cellar;
        }

        private void frmDepotIn_Shown(object sender, EventArgs e)
        {
            txtPallet.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                pallet = new clsPallet(Convert.ToInt32(dataGridView1.Rows[i].Cells[clmCodsec.Index].Value));
                pallet.position = dataGridView1.Rows[i].Cells[clmPosition.Index].Value.ToString();
                pallet.updatePosition(dataGridView1.Rows[i].Cells[clmPosition.Index].Value.ToString());
                if(!Convert.ToBoolean(dataGridView1.Rows[i].Cells[clmPositionChange.Index].Value))
                {
                    clsPallet.transferTo(pallet, Convert.ToInt32(dataGridView1.Rows[i].Cells[clmfkCoilCellar.Index].Value));
                    if (!clsPallet.savein(pallet))
                    {
                        MessageBox.Show("No se pudo generar el archivo de interface con Presea para el pallet " + pallet.code.ToString() + ".", "Error Oben-Presea", MessageBoxButtons.OK);
                    }
                }
                
            }

            MessageBox.Show("Se procesaron todos los movimientos.", "Ingresos a bodega", MessageBoxButtons.OK);
            txtPallet.ResetText();
            txtPosition.ResetText();
            dataGridView1.Rows.Clear();
            txtPallet.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==clmDelete.Index)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
            
        }

        private void chkHangingCoil_CheckedChanged(object sender, EventArgs e)
        {
            txtPallet.Focus();
        }

    }
}
