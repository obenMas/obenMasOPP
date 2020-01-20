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
    public partial class frmCoilCellarReturnsD : Form
    {
       
        
        public frmCoilCellarReturnsD()
        {
            InitializeComponent();
            cmbMovementsTypeCoil.SelectedIndex = 0;
        }

        private void btnProcessCoil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvReturnCoil.Rows.Count; i++)
            {
                clsCoil objcoil = new clsCoil(Convert.ToInt32(dgvReturnCoil.Rows[i].Cells[dataGridViewTextBoxColumn1.Index].Value));
                clsCoilCellar bodega = new clsCoilCellar(objcoil.fkCoilCellar);

                clsReturns objreturn = new clsReturns();
                objreturn.fkCoil = objcoil.codsec;
                objreturn.fkEntity = objcoil.fkEntity;
                objreturn.fkProduct = objcoil.fkProduct;
                objreturn.fkSalesOrder = objcoil.fkSalesOrder;
                objreturn.weigth = objcoil.netWeight;
                objreturn.MovementTypes = dgvReturnCoil.Rows[i].Cells[clmReturnCoilMovementType.Index].Value.ToString();
                objreturn.date = DateTime.Now;
                objreturn.fkPlant = bodega.fkPlant;


                if (clsGlobal.LoggedUser.fkRole == 2032) // Se manda a corte Pilar
                {
                    clsCoil.setCoilAsReturned(objcoil, 4014);
                    clsCoil.transferCoilTo(objcoil.codsec, 4014);
                }
                else // Se manda a conversion Campana. 
                {
                    clsCoil.setCoilAsReturned(objcoil, 11);
                    clsCoil.transferCoilTo(objcoil.codsec,11);
                }

                // clsCoil.setCoilAsReturned(objcoil, clsCoilCellar.getCellarByName("Conversión").codsec); Fuerza a que cualquier devolucion se vaya a conversion O.o
                if(!objreturn.save() || !clsCoil.removeCoilToPallet(objcoil.codsec) || !objcoil.deleteCoilPerSalesOrderDetail(objcoil.codsec))
                {
                    MessageBox.Show("No se pudo procesar correctamente la devolución de la bobina "+objcoil.code, "Reporte de devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvReturnCoil.Rows[i].Cells[clmCheckCoil.Index].Value = BPS.Lite.Properties.Resources.cross;
                }
                else
                {
                    dgvReturnCoil.Rows[i].Cells[clmCheckCoil.Index].Value = BPS.Lite.Properties.Resources.accept;
                }
            }
            MessageBox.Show("Devolucion procesada correctamente. Las bobinas tildadas se ingresaron en la bodega de Conversion para poder generar un nuevo pallet.", "Reporte de devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtReturnCoil_KeyDown(object sender, KeyEventArgs e)
        {
            txtReturnCoil.Text.Trim();

            if (txtReturnCoil.Text != "" & e.KeyCode == Keys.Enter)
            {
                bool coincidence = false;

                clsCoil objcoil = clsCoil.getDetailByCode(txtReturnCoil.Text);
                if (objcoil.fkStatus == 36)//clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas", "Despachada").codsec)
                {
                    if (dgvReturnCoil.Rows.Count>0)
                    {
                        for(int i=0;i<dgvReturnCoil.Rows.Count;i++)
                        {
                            if(dgvReturnCoil.Rows[dgvReturnCoil.Rows.Count - 1].Cells[dataGridViewTextBoxColumn2.Index].Value.ToString()==txtReturnCoil.Text)
                            {
                                coincidence = true;
                            }
                        }
                    }

                    if(!coincidence)
                    {
                        if (objcoil.codsec != 0)
                        {
                            dgvReturnCoil.Rows.Add();
                            dgvReturnCoil.Rows[dgvReturnCoil.Rows.Count - 1].Cells[dataGridViewTextBoxColumn1.Index].Value = objcoil.codsec;
                            dgvReturnCoil.Rows[dgvReturnCoil.Rows.Count - 1].Cells[dataGridViewTextBoxColumn2.Index].Value = objcoil.code;
                            dgvReturnCoil.Rows[dgvReturnCoil.Rows.Count - 1].Cells[dataGridViewTextBoxColumn3.Index].Value = objcoil.customerName;
                            dgvReturnCoil.Rows[dgvReturnCoil.Rows.Count - 1].Cells[dataGridViewTextBoxColumn4.Index].Value = objcoil.salesOrderNumber;
                            dgvReturnCoil.Rows[dgvReturnCoil.Rows.Count - 1].Cells[dataGridViewTextBoxColumn5.Index].Value = objcoil.netWeight;
                            dgvReturnCoil.Rows[dgvReturnCoil.Rows.Count - 1].Cells[clmReturnCoilMovementType.Index].Value = cmbMovementsTypeCoil.SelectedItem.ToString();
                            dgvReturnCoil.Rows[dgvReturnCoil.Rows.Count - 1].Cells[clmCheckCoil.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                        }
                        txtReturnCoil.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("No se puede generar la devolución por la bobina " + txtReturnCoil.Text + ". Esto puede suceder por los siguientes motivos: \n"
                        + "-La bobina no está despachada.\n-La bobina no existe en el sistema.\n-La bobina ya está en la lista.", "Reporte de devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede generar la devolución por la bobina " + txtReturnCoil.Text+". Esto puede suceder por los siguientes motivos: \n"
                    + "-La bobina no está despachada.\n-La bobina no existe en el sistema.\n-La bobina ya está en la lista.", "Reporte de devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvReturnCoil.Rows.Clear();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.button2, "Limpiar");
            
        }

      

    }

}