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

namespace BPS
{
    public partial class frmNewPreShipping : Form
    {
        clsNewPreShipping nps;
        clsNewPreShippingDetail detail = new clsNewPreShippingDetail();
        clsEntity cliente = new clsEntity();
        clsPallet pallet = new clsPallet();
        string mensaje = string.Empty;
        bool palletConProblemaz = false;
        DateTime tempDate = DateTime.Now;

        public frmNewPreShipping(string numb)
        {
            InitializeComponent();
            nps = new clsNewPreShipping(numb);
            completarDatos();
        }

        public frmNewPreShipping(string numb, List<int> listaPal)
        {
            
            InitializeComponent();
            nps = new clsNewPreShipping(numb);
            completarDatos();

            for(int i=0;i<listaPal.Count;i++)
            {
                detail = new clsNewPreShippingDetail(listaPal[i]);
                pallet = new clsPallet(listaPal[i]);

                // Aca se agrega este control para que no puedan despachar pallets en swap y/o otras movidas.

                if (pallet.fkStatus != 38)
                {
                    if (pallet.fkStatus != 3073)
                    {
                        mensaje = mensaje + "El pallet: " + pallet.code + " no se pudo agregar al PD, por que sus estado es: " + new clsStatus(pallet.fkStatus).name + "\n";
                        palletConProblemaz = true;
                    }
                    else
                    {
                        agregar(pallet.fkSalesOrderDetail);     
                    }
                }
                else
                {
                    agregar(pallet.fkSalesOrderDetail);     
                }
            }
            llenarAgregados();
        }

        public void completarDatos()
        {
            txtNumero.Text = nps.number;
            cliente = new clsEntity(nps.fkEntity);
            txtCliente.Text = cliente.companyName;
            txtEstado.Text = new clsStatus(nps.fkStatus).name;
            txtUser.Text = new clsUser(nps.fkUser).userName;
            dtpCreacion.Value = nps.createdDate;
            dtpProgramado.Value = nps.shippingDate;
            txtPallets.Text = "0";
            txtKilos.Text = "0";
            llenarComboPedidos();
            llenarAgregados();
        }

        private void chkDespacho_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDespacho.Checked)
            {
                dtpProgramado.Enabled = true;
                btnProgramar.Enabled = true;
                label6.Enabled = true;
            }
            else
            {
                if(txtEstado.Text=="Programado")
                {
                    dtpProgramado.Enabled = false;
                    btnProgramar.Enabled = false;
                    label6.Enabled = false;
                    tempDate = dtpProgramado.Value;
                    nps.setAsNonProgrammed();
                    nps = new clsNewPreShipping(nps.number);
                    completarDatos();
                }
                
            }
        }

        public void llenarComboPedidos()
        {
            List<int> details = clsSalesOrderDetail.getListByCustomer(cliente.companyName);

            for(int i=0;i<details.Count;i++)
            {
                cmbPedido.Items.Add(details[i]);
            }
        }

        private void cmbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarParaAgregar();
        }

        public void llenarParaAgregar()
        {
            if(cmbPedido.SelectedIndex!=-1)
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("CALL spGetPalletListBySalesOrderDetail(" + cmbPedido.Items[cmbPedido.SelectedIndex].ToString() + ")");

                dgvParaAgregar.Rows.Clear();

                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if (!estaAgregado(Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"])))
                        {
                            dgvParaAgregar.Rows.Add();
                            dgvParaAgregar.Rows[dgvParaAgregar.Rows.Count-1].Cells[fkPalletpa.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                            dgvParaAgregar.Rows[dgvParaAgregar.Rows.Count - 1].Cells[Palletpa.Index].Value = DS.Tables[0].Rows[i]["Codigo"];
                            dgvParaAgregar.Rows[dgvParaAgregar.Rows.Count - 1].Cells[Productopa.Index].Value = DS.Tables[0].Rows[i]["Producto"];
                            dgvParaAgregar.Rows[dgvParaAgregar.Rows.Count - 1].Cells[Pesopa.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                            dgvParaAgregar.Rows[dgvParaAgregar.Rows.Count - 1].Cells[Pedidopa.Index].Value = DS.Tables[0].Rows[i]["sod_codsec"];
                        }
                    }
                }
            }
        }

        private void dgvParaAgregar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==Agregar.Index)
            {
                detail = new clsNewPreShippingDetail(Convert.ToInt32(dgvParaAgregar.Rows[e.RowIndex].Cells[fkPalletpa.Index].Value));
                pallet = new clsPallet(Convert.ToInt32(dgvParaAgregar.Rows[e.RowIndex].Cells[fkPalletpa.Index].Value));
                agregar(Convert.ToInt32(dgvParaAgregar.Rows[e.RowIndex].Cells[Pedidopa.Index].Value));
                llenarParaAgregar();
            }
        }

        public void agregar(int ped)
        {
            if(nps.fkStatus==3067)
            {
                if (detail.codsec == 0)
                {
                    detail.fkNewPreShipping = nps.codsec;
                    detail.fkPallet = pallet.codsec;
                    detail.fkProduct = pallet.fkProduct;
                    detail.fkSaleOrderDetail = ped;
                    detail.netWeight = pallet.netWeight;
                    if (detail.save())
                    {
                        clsPallet.setPalletAsPreShipped(pallet);
                        llenarAgregados();
                    }
                }
                else
                {
                    clsNewPreShipping npsd = new clsNewPreShipping(detail.fkNewPreShipping);
                    if (MessageBox.Show("El pallet " + pallet.code + " ya está agregado en el pre-despacho " + npsd.number + ". Si lo agrega al pre-despacho actual, se borrará del anterior. ¿Desea agregarlo de todas formas?", "Pre-despachos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (detail.delete())
                        {
                            detail = new clsNewPreShippingDetail(pallet.codsec);

                            if (detail.codsec == 0)
                            {
                                detail.fkNewPreShipping = nps.codsec;
                                detail.fkPallet = pallet.codsec;
                                detail.fkProduct = pallet.fkProduct;
                                detail.fkSaleOrderDetail = ped;
                                detail.netWeight = pallet.netWeight;
                                if (detail.save())
                                {
                                    clsPallet.setPalletAsPreShipped(pallet);
                                    llenarAgregados();
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Solo se pueden modificar Pre-despachos con estado Abierto.", "Pre-despachos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void llenarAgregados()
        {
            List<clsNewPreShippingDetail> list = nps.getDetail();
            int cuenta = 0;
            double kilos = 0;

            dgvAgregados.Rows.Clear();

            for(int i=0;i<list.Count;i++)
            {
                pallet = new clsPallet(list[i].fkPallet);
                dgvAgregados.Rows.Add();
                dgvAgregados.Rows[dgvAgregados.Rows.Count - 1].Cells[codsec.Index].Value = list[i].codsec;
                dgvAgregados.Rows[dgvAgregados.Rows.Count - 1].Cells[fkPallet.Index].Value = list[i].fkPallet;
                dgvAgregados.Rows[dgvAgregados.Rows.Count - 1].Cells[Pallet.Index].Value = pallet.code;
                dgvAgregados.Rows[dgvAgregados.Rows.Count - 1].Cells[Producto.Index].Value = pallet.product.code;
                if (list[i].netWeight<1000)
                {
                    dgvAgregados.Rows[dgvAgregados.Rows.Count - 1].Cells[Peso.Index].Value = list[i].netWeight.ToString("0.00");
                }
                else
                {
                    dgvAgregados.Rows[dgvAgregados.Rows.Count - 1].Cells[Peso.Index].Value = list[i].netWeight.ToString("0,000.00");
                }
                dgvAgregados.Rows[dgvAgregados.Rows.Count - 1].Cells[Pedido.Index].Value = list[i].fkSaleOrderDetail;
                cuenta++;
                kilos += list[i].netWeight;
            }

            txtPallets.Text = cuenta.ToString();
            if(kilos<1000)
            {
                txtKilos.Text = kilos.ToString("0.00");
            }
            else
            {
                txtKilos.Text = kilos.ToString("0,000.00");
            }

            if (palletConProblemaz)
            {
                MessageBox.Show(mensaje,"Pallets con problemas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dgvAgregados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==Quitar.Index)
            {
                if(e.RowIndex!=-1)
                {
                    if(nps.fkStatus==3067)
                    {
                        detail = new clsNewPreShippingDetail(Convert.ToInt32(dgvAgregados.Rows[e.RowIndex].Cells[fkPallet.Index].Value));
                        pallet = new clsPallet(Convert.ToInt32(dgvAgregados.Rows[e.RowIndex].Cells[fkPallet.Index].Value));
                        if(detail.delete())
                        {
                            clsPallet.cancelPreShipping(pallet);
                            llenarAgregados();
                            llenarParaAgregar();
                            checkeoSiCierro(nps.getDetailDS()); // TODO: SEGUIR ESTO que quedo a medias
                        }
                        else
                        {
                            MessageBox.Show("Ocurrió un error y no se pudo completar la operación. Consulte con el administrador del sistema.","Pre-despachos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Solo se pueden modificar Pre-despachos con estado Abierto.", "Pre-despachos", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }

        public bool estaAgregado(int fkpal)
        {
            clsNewPreShippingDetail det = new clsNewPreShippingDetail(fkpal);
            if(det.codsec==0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void btnProgramar_Click(object sender, EventArgs e)
        {
            nps.setAsProgrammed(dtpProgramado.Value);
            nps = new clsNewPreShipping(nps.number);
            completarDatos();
        }

        private void checkeoSiCierro(DataSet DS)
        {
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (clsPallet.checkIfDispached(Convert.ToInt32(DS.Tables[0].Rows[i]["npsd_fkPallet"])) && (i+1 == DS.Tables[0].Rows.Count))
                    {
                        nps.setAsProgrammed(tempDate);
                        nps = new clsNewPreShipping(nps.number);

                        if (nps.setAsDispatched())
                        {
                            MessageBox.Show("Como todos los pallets dentro del PD estaban despachados se cambio a despachado el estado del PD", "Despachado", MessageBoxButtons.OK, MessageBoxIcon.Information);    
                        }
                        else
                        {
                            MessageBox.Show("No se pudo despachar el PD, siendo que estan todos los pallets despachados. \n Por favor, contacte con el administrador del sistema.", "Error Despachado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (!clsPallet.checkIfDispached(Convert.ToInt32(DS.Tables[0].Rows[i]["npsd_fkPallet"])))
                    {
                        break;
                    }
                }
            }
        }
    }
}
