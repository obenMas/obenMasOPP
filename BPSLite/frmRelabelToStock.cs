using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using System.Threading;

namespace BPS.Lite
{
    public partial class frmRelabelToStock : Form
    {
        clsPallet pallet = new clsPallet();
        List<clsCoil> coilList = new List<clsCoil>();
        clsCoil coil = new clsCoil();
        clsReassign reassignCP = new clsReassign();
        clsReassignPL reassignPL = new clsReassignPL();
         

        public frmRelabelToStock()
        {
            InitializeComponent();
        }

        #region Cambio de pallets

        private void txtCodigoPallet_KeyDown(object sender, KeyEventArgs e)
        {
            bool bandera = false;

            if (e.KeyCode == Keys.Enter)
            {
                this.pallet = clsPallet.getDetailByCode(txtCodigoPallet.Text);
                txtCodigoPallet.BackColor = Color.White;
                clsProduct producto = new clsProduct(pallet.fkProduct);

                if (pallet.codsec != 0)
                {
                    if(pallet.fkStatus == 38 || pallet.fkStatus ==  42 || pallet.fkStatus == 40)  // Se fija si el pallet esta, Activo(38), Abierto(42) o Despachado(40)
                    {   
                        txtCodigoPallet.BackColor = Color.LightGreen;
                        if (dgvRelabel.Rows.Count > 0) //El dgv esta vacío. 
                        {

                            txtCodigoPallet.BackColor = Color.LightGreen;

                            foreach (DataGridViewRow rows in dgvRelabel.Rows)
                            {
                                if (pallet.code == Convert.ToString(rows.Cells[clmCode.Index].Value))
                                {
                                    MessageBox.Show("El codigo ya se encuentra ingresado, por favor verifique la tabla", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    bandera = true;
                                    txtCodigoPallet.BackColor = Color.LightSalmon;
                                }
                            }

                            if (!bandera)
                            {
                                dgvRelabel.Rows.Add();
                                dgvRelabel.Rows[dgvRelabel.Rows.Count - 1].Cells[clmCode.Index].Value = pallet.code;
                                dgvRelabel.Rows[dgvRelabel.Rows.Count - 1].Cells[clmPeso.Index].Value = pallet.netWeight;
                                dgvRelabel.Rows[dgvRelabel.Rows.Count - 1].Cells[clmProducto.Index].Value = producto.code;
                                dgvRelabel.Rows[dgvRelabel.Rows.Count - 1].Cells[clmSaleOrder.Index].Value = pallet.salesOrderNumber;
                                dgvRelabel.Rows[dgvRelabel.Rows.Count - 1].Cells[clmCoilCount.Index].Value = pallet.lstCoil.Count;
                                dgvRelabel.Rows[dgvRelabel.Rows.Count - 1].Cells[clmCliente.Index].Value = pallet.customerName;

                                txtCodigoPallet.Text = string.Empty;
                            }
                        
                        }
                        else
                        {
                            dgvRelabel.Rows.Add();
                            dgvRelabel.Rows[dgvRelabel.Rows.Count - 1].Cells[clmCode.Index].Value = pallet.code;
                            dgvRelabel.Rows[dgvRelabel.Rows.Count - 1].Cells[clmPeso.Index].Value = pallet.netWeight;
                            dgvRelabel.Rows[dgvRelabel.Rows.Count - 1].Cells[clmProducto.Index].Value = producto.code;
                            dgvRelabel.Rows[dgvRelabel.Rows.Count - 1].Cells[clmSaleOrder.Index].Value = pallet.salesOrderNumber;
                            dgvRelabel.Rows[dgvRelabel.Rows.Count - 1].Cells[clmCoilCount.Index].Value = pallet.lstCoil.Count;

                            txtCodigoPallet.Text = string.Empty;
                        }
                        
                    }
                    else
                    {
                        txtCodigoPallet.BackColor = Color.LightSalmon;
                        MessageBox.Show("El pallet debe de estar activo para poder realizar esta acción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                  
                }
                else
                {
                    txtCodigoPallet.BackColor = Color.LightSalmon;
                    MessageBox.Show("El codigo de pallet ingreado no existe o es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void btnProcesPallet_Click(object sender, EventArgs e)
        {
            bool anduvoPal = false;
            bool anduvolstCoil = false;
            bool anduvoreasignCP = false;
            bool anduvoreasignPL = false;
            bool vbreak = false;

            for (int j = 0; j < dgvRelabel.Rows.Count; j++)
            {
                pallet = clsPallet.getDetailByCode(dgvRelabel.Rows[j].Cells[clmCode.Index].Value.ToString());

                var dialogResult = MessageBox.Show("¿Desea imprimir las etiquetas?", "Impresion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (pallet.codsec != 0)
                {
                    // Se Levanta el registro en reassign
                    if (clsGlobal.LoggedUser.fkRole == 2022 || clsGlobal.LoggedUser.fkRole == 2023 || clsGlobal.LoggedUser.fkRole == 2024 || clsGlobal.LoggedUser.fkRole == 11 || clsGlobal.LoggedUser.codsec == 5164)
                    {
                        reassignCP.fkPallet = pallet.codsec;
                        reassignCP.weigth = pallet.netWeight;
                        reassignCP.fkOldSalesOrderDetail = Convert.ToInt32(pallet.salesOrderNumber);
                        reassignCP.fkNewSalesOrderDetail = 0;
                        reassignCP.date = DateTime.Now;
                        reassignCP.fkUser = clsGlobal.LoggedUser.codsec;

                        anduvoreasignCP = reassignCP.save();
                    }
                    else
                    {
                        reassignPL.palletCode = pallet.code;
                        reassignPL.weigth = pallet.netWeight;
                        reassignPL.fkOldSalesOrderDetail = Convert.ToInt32(pallet.salesOrderNumber);
                        reassignPL.fkNewSalesOrderDetail = 0;
                        reassignPL.date = DateTime.Now;
                        reassignPL.fkUser = clsGlobal.LoggedUser.codsec;

                        anduvoreasignPL = reassignPL.save();
                    }

                    // Obtengo la lista de bobinas del pallet
                    coilList = clsCoil.getCoilListByPallet(pallet.codsec);

                    // Se pasa el pallet a stock
                    anduvoPal = pallet.deleteSalesOrderDetail(pallet.codsec);

                    // Se pasan las bobinas a stock.
                    for (int i = 0; i < coilList.Count; i++)
                    {
                        anduvolstCoil = coil.deleteCoilPerSalesOrderDetail(coilList[i].codsec);
                    }
                }

                // Si no imprime etiquetas es que alguno de estos no anduvo. 

                if (anduvolstCoil == true && anduvoPal == true && (anduvoreasignCP == true || anduvoreasignPL == true))
                {
                    if (DialogResult.Yes == dialogResult)
                    {
                        for (int i = 0; i < coilList.Count; i++)
                        {
                            if (clsGlobal.LoggedUser.fkRole == 2022 || clsGlobal.LoggedUser.fkRole == 2023 || clsGlobal.LoggedUser.fkRole == 2024 || clsGlobal.LoggedUser.codsec == 5164)
                            {
                                clsPrintLabels.printPalletLabel(pallet.codsec, "local");
                                clsPrintLabels.printCoilLabel(coilList[i].codsec, coilList[i].isExternalCoil);
                            }
                            else
                            {
                                clsPrintLabels.printPalletLabel(pallet.codsec, "local");
                                clsPrintLabels.printCoilLabelPL(coilList[i].codsec, coilList[i].isExternalCoil);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Se produjo un error en la pasada a Stock en el pallet" + pallet.code +"por favor contacte con el Administrador del sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                    vbreak = true;
                }
            }

            if (!vbreak)
            {
                MessageBox.Show("Datos Procesados con exito", "¡Exito!", MessageBoxButtons.OK);
                txtCodigoPallet.Clear();
                txtCodigoPallet.BackColor = Color.White;
                dgvRelabel.Rows.Clear();
            }
            
        }
        #endregion

        #region Cambio de Bobina

        private void txtCoilCode_KeyDown(object sender, KeyEventArgs e)
        {
            bool bandera = false;

            if (e.KeyCode == Keys.Enter)
            {
                coil = clsCoil.getDetailByCode(txtCoilCode.Text);
                txtCoilCode.BackColor = Color.White;
                clsSalesOrder cliente = new clsSalesOrder(coil.fkSalesOrder);

                if (coil.codsec != 0)
                {
                    txtCoilCode.BackColor = Color.LightGreen;

                    if (dgvRlblCoil.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow rows in dgvRlblCoil.Rows)
                        {
                            if (coil.code == Convert.ToString(rows.Cells[clmCodBob.Index].Value))
                            {
                                MessageBox.Show("El codigo ya se encuentra ingresado, por favor verifique la tabla", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                bandera = true;
                                txtCoilCode.BackColor = Color.LightSalmon;
                            }

                            if (!bandera)
                            {
                                dgvRlblCoil.Rows.Add();
                                dgvRlblCoil.Rows[dgvRlblCoil.Rows.Count - 1].Cells[clmCodsecCoil.Index].Value = coil.codsec;
                                dgvRlblCoil.Rows[dgvRlblCoil.Rows.Count - 1].Cells[clmCodBob.Index].Value = coil.code;
                                dgvRlblCoil.Rows[dgvRlblCoil.Rows.Count - 1].Cells[clmLength.Index].Value = coil.length;
                                dgvRlblCoil.Rows[dgvRlblCoil.Rows.Count - 1].Cells[clmPeso.Index].Value = coil.netWeight;
                                dgvRlblCoil.Rows[dgvRlblCoil.Rows.Count - 1].Cells[clmProdCoil.Index].Value = coil.ProductCode;
                                dgvRlblCoil.Rows[dgvRlblCoil.Rows.Count - 1].Cells[clmSoDCoil.Index].Value = coil.fkSalesOrderDetail;
                                dgvRlblCoil.Rows[dgvRlblCoil.Rows.Count - 1].Cells[clmClientCoil.Index].Value = cliente.EntityName;
                                dgvRlblCoil.Rows[dgvRlblCoil.Rows.Count - 1].Cells[clmIsExternal.Index].Value = coil.isExternalCoil;
                            }
                        }
                    }
                    else
                    {
                        dgvRlblCoil.Rows.Add();
                        dgvRlblCoil.Rows[dgvRlblCoil.Rows.Count - 1].Cells[clmCodsecCoil.Index].Value = coil.codsec;
                        dgvRlblCoil.Rows[dgvRlblCoil.Rows.Count - 1].Cells[clmCodBob.Index].Value = coil.code;
                        dgvRlblCoil.Rows[dgvRlblCoil.Rows.Count - 1].Cells[clmLength.Index].Value = coil.length;
                        dgvRlblCoil.Rows[dgvRlblCoil.Rows.Count - 1].Cells[clmPeso.Index].Value = coil.netWeight;
                        dgvRlblCoil.Rows[dgvRlblCoil.Rows.Count - 1].Cells[clmProdCoil.Index].Value = coil.ProductCode;
                        dgvRlblCoil.Rows[dgvRlblCoil.Rows.Count - 1].Cells[clmSoDCoil.Index].Value = coil.fkSalesOrderDetail;
                        dgvRlblCoil.Rows[dgvRlblCoil.Rows.Count - 1].Cells[clmClientCoil.Index].Value = cliente.EntityName;
                        dgvRlblCoil.Rows[dgvRlblCoil.Rows.Count - 1].Cells[clmIsExternal.Index].Value = coil.isExternalCoil;
                    }
                   

                }
                else
                {
                    txtCoilCode.BackColor = Color.LightSalmon;
                    MessageBox.Show("El codigo de bobina ingreado no existe o es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnProcesCoil_Click(object sender, EventArgs e)
        {
            bool anduvoCoil = false;
            bool anduvoReasignCP = false;
            bool anduvoReasignPL = false;

            var dialogResult = MessageBox.Show("¿Desea imprimir las etiquetas?", "Impresion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            for (int k = 0; k < dgvRlblCoil.Rows.Count; k++)
            {

                anduvoCoil = coil.deleteCoilPerSalesOrderDetail(Convert.ToInt32(dgvRlblCoil.Rows[k].Cells[clmCodsecCoil.Index].Value));

                if (clsGlobal.LoggedUser.fkRole == 2022 || clsGlobal.LoggedUser.fkRole == 2023 || clsGlobal.LoggedUser.fkRole == 2024)
                {
                    reassignCP.date = DateTime.Now;
                    reassignCP.fkNewSalesOrderDetail = 0;
                    reassignCP.fkOldSalesOrderDetail = coil.fkSalesOrderDetail;
                    reassignCP.fkUser = clsGlobal.LoggedUser.codsec;
                    reassignCP.weigth = coil.netWeight;
                    reassignCP.save();
                }
                else
                {
                    reassignPL.date = DateTime.Now;
                    reassignPL.fkNewSalesOrderDetail = 0;
                    reassignPL.fkOldSalesOrderDetail = coil.fkSalesOrderDetail;
                    reassignPL.fkUser = clsGlobal.LoggedUser.codsec;
                    reassignPL.weigth = coil.netWeight;
                    reassignPL.save();
                }

                if (anduvoCoil && (anduvoReasignCP || anduvoReasignPL))
                {
                    if (DialogResult.Yes == DialogResult)
                    {
                        if (clsGlobal.LoggedUser.fkRole == 2022 || clsGlobal.LoggedUser.fkRole == 2023 || clsGlobal.LoggedUser.fkRole == 2024)
                        {
                            clsPrintLabels.printCoilLabel(Convert.ToInt32(dgvRlblCoil.Rows[k].Cells[clmCodsec.Index].Value), Convert.ToBoolean(dgvRlblCoil.Rows[k].Cells[clmIsExternal.Index].Value));
                        }
                        else
                        {
                            clsPrintLabels.printCoilLabelPL(Convert.ToInt32(dgvRlblCoil.Rows[k].Cells[clmCodsec.Index].Value), Convert.ToBoolean(dgvRlblCoil.Rows[k].Cells[clmIsExternal.Index].Value));
                        }
                    }
                }

            }

                if (anduvoCoil)
                {
                    MessageBox.Show("Datos Procesados con exito", "¡Exito!", MessageBoxButtons.OK);
                    txtCoilCode.Clear();
                    txtCoilCode.BackColor = Color.White;
                }
                else
                {
                    MessageBox.Show("No se pudo liberar a stock", "¡Exito!", MessageBoxButtons.OK);
                }
                
        }

        #endregion

    }
}
