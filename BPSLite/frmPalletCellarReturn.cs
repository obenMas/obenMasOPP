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
    public partial class frmPalletCellarReturn : Form
    {
        public frmPalletCellarReturn()
        {
            InitializeComponent();
        }

        private void btnProcessPallet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvReturnPallet.Rows.Count; i++)
            {
                clsPallet objpallet = new clsPallet(Convert.ToInt32(dgvReturnPallet.Rows[i].Cells[clmCodsec.Index].Value));
                clsCoilCellar bodega = new clsCoilCellar(objpallet.fkPalletCoilcellar);
                clsEntity cliente = new clsEntity(objpallet.customerName);

                clsReturns objreturn = new clsReturns();
                objreturn.fkPallet = objpallet.codsec;
                objreturn.fkEntity = cliente.codsec;
                objreturn.fkProduct = objpallet.fkProduct;
                objreturn.fkSalesOrder = objpallet.fkSalesOrder;
                objreturn.weigth = objpallet.netWeight;
                objreturn.MovementTypes = " Movimiento Interno";
                objreturn.date = DateTime.Now;
                objreturn.fkPlant = bodega.fkPlant;

                clsPallet.setPalletAsReturned(objpallet.codsec);
                clsPallet.transferTo(objpallet.codsec, 4013);

                clsNewPreShipping np = new clsNewPreShipping(new clsNewPreShippingDetail(objpallet.codsec).fkNewPreShipping);
                np.setAsProgrammed(np.shippingDate);
                //if (clsGlobal.LoggedUser.fkRole == 2032) // Se manda a corte Pilar
                //{
                //    clsCoil.setCoilAsReturned(objcoil, 4014);
                //    clsCoil.transferCoilTo(objcoil.codsec, 4014);
                //}
                //else // Se manda a conversion Campana. 
                //{
                //    clsCoil.setCoilAsReturned(objcoil, 11);
                //    clsCoil.transferCoilTo(objcoil.codsec, 11);
                //}

                // clsCoil.setCoilAsReturned(objcoil, clsCoilCellar.getCellarByName("Conversión").codsec); Fuerza a que cualquier devolucion se vaya a conversion O.o
                if (!objreturn.save())
                {
                    MessageBox.Show("No se pudo procesar correctamente la devolución de el pallet " + objpallet.code, "Reporte de devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvReturnPallet.Rows[i].Cells[clmCheckPallet.Index].Value = BPS.Lite.Properties.Resources.cross;
                }
                else
                {
                    dgvReturnPallet.Rows[i].Cells[clmCheckPallet.Index].Value = BPS.Lite.Properties.Resources.accept;
                }
            }
            MessageBox.Show("Devolucion procesada correctamente. Los pallets tildadas se ingresaron en la bodega de Conversion para poder generar un nuevo pallet.", "Reporte de devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtReturnPallet_KeyDown(object sender, KeyEventArgs e)
        {
            txtReturnPallet.Text.Trim();

            if (txtReturnPallet.Text != "" & e.KeyCode == Keys.Enter)
            {
                bool coincidence = false;

                clsPallet objpallet = clsPallet.getDetailByCode(txtReturnPallet.Text);
                if (objpallet.fkStatus == 40)//clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas", "Despachada").codsec)
                {
                    if (dgvReturnPallet.Rows.Count > 0)
                    {
                        for (int i = 0; i < dgvReturnPallet.Rows.Count; i++)
                        {
                            if (dgvReturnPallet.Rows[dgvReturnPallet.Rows.Count - 1].Cells[clmCodigo.Index].Value.ToString() == txtReturnPallet.Text)
                            {
                                coincidence = true;
                            }
                        }
                    }

                    if (!coincidence)
                    {
                        if (objpallet.codsec != 0)
                        {
                            dgvReturnPallet.Rows.Add();
                            dgvReturnPallet.Rows[dgvReturnPallet.Rows.Count - 1].Cells[clmCodsec.Index].Value = objpallet.codsec;
                            dgvReturnPallet.Rows[dgvReturnPallet.Rows.Count - 1].Cells[clmCodigo.Index].Value = objpallet.code;
                            dgvReturnPallet.Rows[dgvReturnPallet.Rows.Count - 1].Cells[clmCliente.Index].Value = objpallet.customerName;
                            dgvReturnPallet.Rows[dgvReturnPallet.Rows.Count - 1].Cells[clmOv.Index].Value = objpallet.fkSalesOrderDetail;
                            dgvReturnPallet.Rows[dgvReturnPallet.Rows.Count - 1].Cells[clmPeso.Index].Value = objpallet.netWeight;
                            dgvReturnPallet.Rows[dgvReturnPallet.Rows.Count - 1].Cells[clmMovimiento.Index].Value = " Movimiento Interno";
                            dgvReturnPallet.Rows[dgvReturnPallet.Rows.Count - 1].Cells[clmCheckPallet.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                        }
                        txtReturnPallet.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("No se puede generar la devolución por el pallet " + txtReturnPallet.Text + ". Esto puede suceder por los siguientes motivos: \n"
                        + "-El pallet no está despachado.\n-El pallet no existe en el sistema.\n-El pallet ya está en la lista.", "Reporte de devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede generar la devolución por el pallet " + txtReturnPallet.Text + ". Esto puede suceder por los siguientes motivos: \n"
                    + "-El pallet no está despachado.\n-El pallet no existe en el sistema.\n-El pallet ya está en la lista.", "Reporte de devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvReturnPallet.Rows.Clear();
        }

        private void dgvReturnPallet_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvReturnPallet.Rows.RemoveAt(e.RowIndex);
        }
    }
}
