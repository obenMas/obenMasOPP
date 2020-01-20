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
    public partial class frmCuttingOrderListSelector : Form
    {
        clsStatus status = new clsStatus();
        DataSet DS = new DataSet();
        DataSet DSDGV = new DataSet();
        int num=0;
        public frmCuttingOrderListSelector()
        {
            InitializeComponent();
            ObtenerDS("CALL spCuttingOrderByLimit");
            LlenarTxts();
        }
        public void LlenarTxts()
        {
            if (DS.Tables[0].Rows.Count > 0 && DS.Tables.Count > 0)
            {
                txtOC.Text = DS.Tables[0].Rows[0]["cord_codsec"].ToString();
                txtNum.Text = DS.Tables[0].Rows[0]["cord_codsec"].ToString();
                txtMaquina.Text = DS.Tables[0].Rows[0]["cord_machineName"].ToString();
                txtPelicula.Text = DS.Tables[0].Rows[0]["cord_boppName"].ToString();
                txtProducto.Text = DS.Tables[0].Rows[0]["cord_productName"].ToString();
                txtEstado.Text = DS.Tables[0].Rows[0]["cord_StatusName"].ToString();
                txtPosiciones.Text = DS.Tables[0].Rows[0]["cord_positions"].ToString();
                txtRepeticiones.Text = DS.Tables[0].Rows[0]["cord_repetitions"].ToString();
                txtFecha.Text = DS.Tables[0].Rows[0]["cord_createdDate"].ToString();
                txtCodPelicula.Text = DS.Tables[0].Rows[0]["cord_boppCode"].ToString();
                txtCodProducto.Text = DS.Tables[0].Rows[0]["cord_productCode"].ToString();
                num = Convert.ToInt32(txtNum.Text);
                if (DS.Tables[0].Rows[0]["cord_isSecundaryCut"].ToString() == "1")
                    cbCorteSecundario.Checked = true;
                else
                    cbCorteSecundario.Checked = false;
                txtNotas.Text = DS.Tables[0].Rows[0]["cord_notes"].ToString();
                ObtenerDSDGV();
                LlenarDGV();
            }
            else
            {
                MessageBox.Show("No se encontraron datos", "Lista de ordenes de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum.Text = num.ToString();
            }
        }
        public void LlenarDGV()
        {
            if( DSDGV.Tables.Count>0 && DSDGV.Tables[0].Rows.Count!=0)
            {
                dgvCuttingOrderDetail.Rows.Clear();
                for (int i = 0; i < DSDGV.Tables[0].Rows.Count; i++)
                {
                    dgvCuttingOrderDetail.Rows.Add();
                    dgvCuttingOrderDetail.Rows[i].Cells[clmCuttingOrderDetailCodsec.Index].Value = DSDGV.Tables[0].Rows[i]["cod_codsec"].ToString();
                    dgvCuttingOrderDetail.Rows[i].Cells[clmfkCuttingOrder.Index].Value = DSDGV.Tables[0].Rows[i]["cod_fkCuttingOrder"].ToString();
                    dgvCuttingOrderDetail.Rows[i].Cells[clmProducto.Index].Value = DSDGV.Tables[0].Rows[i]["cod_productName"].ToString();
                    dgvCuttingOrderDetail.Rows[i].Cells[clmCodProducto.Index].Value = DSDGV.Tables[0].Rows[i]["prod_code"].ToString();
                    dgvCuttingOrderDetail.Rows[i].Cells[clmAncho.Index].Value = DSDGV.Tables[0].Rows[i]["prod_width"].ToString();
                    dgvCuttingOrderDetail.Rows[i].Cells[clmPosicion.Index].Value = DSDGV.Tables[0].Rows[i]["cod_position"].ToString();
                    dgvCuttingOrderDetail.Rows[i].Cells[clmfkSalesOrderDetail.Index].Value = DSDGV.Tables[0].Rows[i]["cod_fkSalesOrderDetail"].ToString();
                    dgvCuttingOrderDetail.Rows[i].Cells[clmCliente.Index].Value = DSDGV.Tables[0].Rows[i]["entt_companyName"].ToString();
                    dgvCuttingOrderDetail.Rows[i].Cells[clmfkSalesOrder.Index].Value = DSDGV.Tables[0].Rows[i]["cod_SalesOrderNumber"].ToString();
                }
            }
            else
                MessageBox.Show("No se encontraron detalles de la orden", "Lista de ordenes de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ObtenerDS(string query)
        {
            DS = clsConnection.getDataSetResult(query);
        }
        public void ObtenerDSDGV()
        {
            DSDGV = clsConnection.getDataSetResult("CALL spCuttingOrdersDetails(" + txtNum.Text + ")");
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            DataSet DS2 = new DataSet();
            DS2 = clsConnection.getDataSetResult("CALL spCuttingOrderFirstOrLast(1)");
            if (DS2.Tables[0].Rows[0]["cord_codsec"].ToString() != txtNum.Text)
            {
                DataSet DS3 = new DataSet();
                DS3=clsConnection.getDataSetResult("CALL spCuttingOrderExist("+num.ToString()+")");
                bool existe=false;
                while(existe==false)
                {
                    if (DS3.Tables.Count > 0 && DS3.Tables[0].Rows.Count > 0 && Convert.ToInt32(DS2.Tables[0].Rows[0]["cord_codsec"]) != num)
                    {
                        num++;
                        DS3 = clsConnection.getDataSetResult("CALL spCuttingOrderExist(" + num.ToString() + ")");
                        if (DS3.Tables[0].Rows.Count > 0)
                        {
                            ObtenerDS("CALL spCuttingOrderByCodsec(" + num.ToString() + ")");
                            existe = true;
                        }
                    }
                }
            }
            else
                MessageBox.Show("Este es el ultimo registro", "Lista de ordenes de corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LlenarTxts();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            DataSet DS2 = new DataSet();
            DS2 = clsConnection.getDataSetResult("CALL spCuttingOrderFirstOrLast(0)");
            if (DS2.Tables[0].Rows[0]["cord_codsec"].ToString() != txtNum.Text)
            {
                DataSet DS3 = new DataSet();
                DS3 = clsConnection.getDataSetResult("CALL spCuttingOrderExist(" + num.ToString() + ")");
                bool existe = false;
                while (existe == false)
                {
                    if (DS3.Tables.Count > 0 && DS3.Tables[0].Rows.Count > 0 && Convert.ToInt32(DS2.Tables[0].Rows[0]["cord_codsec"]) != num)
                    {
                        num--;
                        DS3 = clsConnection.getDataSetResult("CALL spCuttingOrderExist(" + num.ToString() + ")");
                        if (DS3.Tables[0].Rows.Count > 0)
                        {
                            ObtenerDS("CALL spCuttingOrderByCodsec(" + num.ToString() + ")");
                            existe = true;
                        }
                    }
                }
            }
            else
                MessageBox.Show("Este es el primer registro", "Lista de ordenes de corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LlenarTxts();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            ObtenerDS("CALL spCuttingOrderFirstOrLast(0)");
            LlenarTxts();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            ObtenerDS("CALL spCuttingOrderFirstOrLast(1)");
            LlenarTxts();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && txtNum.Text!=string.Empty)
            {
                DataSet existe= new DataSet();
                existe=clsConnection.getDataSetResult("CALL spCuttingOrderExist("+txtNum.Text+")");
                if (existe.Tables.Count > 0 && existe.Tables[0].Rows.Count > 0)
                {
                    ObtenerDS("CALL spCuttingOrderByCodsec(" + txtNum.Text + ")");
                    LlenarTxts();
                }
                else
                {
                    MessageBox.Show("El registro no existe", "Lista de ordenes de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNum.Text = num.ToString();
                }
                txtNum.SelectAll();
            }
            if(DS.Tables.Count==0)
            {
                MessageBox.Show("Esta orden no existe", "Lista de ordenes de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum.Text = num.ToString();
            }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtNum.Text) == false && txtNum.Text != "")
            {
                MessageBox.Show("El valor debe ser Numérico");
                txtNum.Text = num.ToString();
            }
        }

        private void txtNum_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtEstado.Text != "Cerrada")
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar la orden?", "Lista de ordenes de corte", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (clsCuttingOrderDetail.DeleteByCuttingOrderCodsec(Convert.ToInt32(txtNum.Text)) && clsCuttingOrder.DeleteByCodsec(Convert.ToInt32(txtNum.Text)))
                    {
                        MessageBox.Show("Orden eliminada correctamente!", "Lista de ordenes de corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        num--;
                        txtNum.Text = num.ToString();
                        ObtenerDS("CALL spCuttingOrderByCodsec(" + txtNum.Text + ")");
                        LlenarTxts();
                    }
                }
            }
            else
                MessageBox.Show("No puede eliminar una orden cerrada", "Lista de ordenes de corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
