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
            llenarAgregados();
        }

        public frmNewPreShipping(string numb, List<int> listaPal, List<int> listaProd, List<double> listanw, List<int> listaped)
        {
            
            InitializeComponent();
            nps = new clsNewPreShipping(numb);
            completarDatos();

            for(int i=0;i<listaPal.Count;i++)
            {
                detail = new clsNewPreShippingDetail(listaPal[i]);

                if (detail.codsec == 0)
                {
                    detail.fkNewPreShipping = nps.codsec;
                    detail.fkPallet = listaPal[i];
                    detail.fkProduct = listaProd[i];
                    detail.fkSaleOrderDetail = listaped[i];
                    detail.netWeight = listanw[i];
                    if (detail.save())
                    {
                        clsPallet.setPalletAsPreShipped(listaPal[i]);
                        //llenarAgregados();
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
                                detail.fkPallet = listaPal[i];
                                detail.fkProduct = listaProd[i];
                                detail.fkSaleOrderDetail = listaped[i];
                                detail.netWeight = listanw[i];
                                if (detail.save())
                                {
                                    clsPallet.setPalletAsPreShipped(listaPal[i]);
                                    //llenarAgregados();
                                }
                            }
                        }
                    }
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
            if(nps.fkStatus==3068)
            {
                chkDespacho.Checked = true;
            }
            //llenarAgregados();
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

        public void llenarAgregados()
        {
            DataSet DS = nps.getDSDetail();
            int cuenta = 0;
            double kilos = 0;

            dgvAgregados.Rows.Clear();
            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvAgregados.Rows.Add();
                    dgvAgregados.Rows[dgvAgregados.Rows.Count - 1].Cells[codsec.Index].Value = DS.Tables[0].Rows[i]["codsec"];
                    dgvAgregados.Rows[dgvAgregados.Rows.Count - 1].Cells[fkPallet.Index].Value = DS.Tables[0].Rows[i]["fkPallet"];
                    dgvAgregados.Rows[dgvAgregados.Rows.Count - 1].Cells[clmPallet.Index].Value = DS.Tables[0].Rows[i]["palletCode"];
                    dgvAgregados.Rows[dgvAgregados.Rows.Count - 1].Cells[clmProducto.Index].Value = DS.Tables[0].Rows[i]["productCode"];
                    if (Convert.ToDouble(DS.Tables[0].Rows[i]["netWeight"]) < 1000)
                    {
                        dgvAgregados.Rows[dgvAgregados.Rows.Count - 1].Cells[clmPeso.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["netWeight"]).ToString("0.00");
                    }
                    else
                    {
                        dgvAgregados.Rows[dgvAgregados.Rows.Count - 1].Cells[clmPeso.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["netWeight"]).ToString("0,000.00");
                    }
                    dgvAgregados.Rows[dgvAgregados.Rows.Count - 1].Cells[clmPedido.Index].Value = DS.Tables[0].Rows[i]["fkSaleOrderDetail"];
                    cuenta++;
                    kilos += Convert.ToDouble(DS.Tables[0].Rows[i]["netWeight"]);
                }
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
            if(e.ColumnIndex==clmQuitar.Index)
            {
                if(e.RowIndex!=-1)
                {
                    if(nps.fkStatus==3067)
                    {
                        detail = new clsNewPreShippingDetail(Convert.ToInt32(dgvAgregados.Rows[e.RowIndex].Cells[fkPallet.Index].Value));

                        if(detail.delete())
                        {
                            clsPallet.cancelPreShipping(Convert.ToInt32(dgvAgregados.Rows[e.RowIndex].Cells[fkPallet.Index].Value));
                            txtPallets.Text = (Convert.ToInt32(txtPallets.Text)-1).ToString();
                            double kilos = (Convert.ToDouble(txtKilos.Text) - Convert.ToDouble(dgvAgregados.Rows[e.RowIndex].Cells[clmPeso.Index].Value));
                            if (kilos < 1000)
                            {
                                txtKilos.Text = kilos.ToString("0.00");
                            }
                            else
                            {
                                txtKilos.Text = kilos.ToString("0,000.00");
                            }
                            dgvAgregados.Rows.Remove(dgvAgregados.Rows[e.RowIndex]);
                            //llenarAgregados();
                            //checkeoSiCierro(nps.getDetailDS()); // TODO: SEGUIR ESTO que quedo a medias
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
            //completarDatos();
            txtEstado.Text = new clsStatus(nps.fkStatus).name;
            MessageBox.Show("Despacho programado correctamente","Edición de PD",MessageBoxButtons.OK);
            this.Close();
        }

        /*private void checkeoSiCierro(DataSet DS)
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
        }*/
    }
}
