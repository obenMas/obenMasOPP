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
    public partial class frmSalesOrderObjetive : Form
    {
        string ejecutiva = string.Empty;
        string cliente = string.Empty;
        string nombrecompleto = string.Empty;

        string lastChange = string.Empty;

        public frmSalesOrderObjetive()
        {
            InitializeComponent();
            
        }

        private void frmSalesOrderObjetive_Load(object sender, EventArgs e)
        {
            populateDgv();
        }

        private void populateDgv()
        {

            string queryString = "";
            DataSet DS = new DataSet();

            List<string> ejecutivas = new List<string>();
            List<string> clientes = new List<string>();
            
            queryString = "CALL spClientAndEjByFkEntity()";

            DS = clsConnection.getDataSetResult(queryString);

            if (lastChange != "ejecutiva")
            {
                cmbEjecutiva.Items.Clear();
            }
            if (lastChange != "cliente")
            {
                cmbCliente.Items.Clear();
            }

            dgvSaleOrderObj.Rows.Clear();    

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i=0; i < DS.Tables[0].Rows.Count; i++)
                {
                    
                    string concat = ejecutiva + cliente;

                    string concat2 = string.Empty;
                    nombrecompleto = DS.Tables[0].Rows[i]["nomEjecutiva"].ToString() + " " + DS.Tables[0].Rows[i]["apeEjecutiva"].ToString();

                    if (ejecutiva != string.Empty)
                    {
                        concat2 += nombrecompleto; 
                    }
                    if (cliente != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["nombreComp"].ToString();
                    }

                    if (concat == concat2)
                    {

                        dgvSaleOrderObj.Rows.Add();
                        dgvSaleOrderObj.Rows[dgvSaleOrderObj.Rows.Count - 1].Cells[clmCodsec.Index].Value = DS.Tables[0].Rows[i]["codsec"];
                        dgvSaleOrderObj.Rows[dgvSaleOrderObj.Rows.Count - 1].Cells[clmEjecutiva.Index].Value = nombrecompleto;
                        dgvSaleOrderObj.Rows[dgvSaleOrderObj.Rows.Count - 1].Cells[clmCliente.Index].Value = DS.Tables[0].Rows[i]["nombreComp"];
                        dgvSaleOrderObj.Rows[dgvSaleOrderObj.Rows.Count - 1].Cells[clmObjetivo.Index].Value = DS.Tables[0].Rows[i]["Objetivo"];
                        dgvSaleOrderObj.Rows[dgvSaleOrderObj.Rows.Count - 1].Cells[clmFkEntity.Index].Value = DS.Tables[0].Rows[i]["fkEntity"];

                        if (!ejecutivas.Contains(nombrecompleto))
                            ejecutivas.Add(nombrecompleto);

                        if (!clientes.Contains(DS.Tables[0].Rows[i]["nombreComp"].ToString()))
                            clientes.Add(DS.Tables[0].Rows[i]["nombreComp"].ToString());
                    }
                }

                ejecutivas.Sort();
                clientes.Sort();


                if (lastChange != "ejecutiva")
                {
                    for (int i = 0; i < ejecutivas.Count; i++)
                    {
                        cmbEjecutiva.Items.Add(ejecutivas[i]);
                    }
                }

                if (lastChange != "cliente")
                {
                    for (int i = 0; i < clientes.Count; i++)
                    {
                        cmbCliente.Items.Add(clientes[i]);
                    }
                }
            }
            else
            {
                queryString = "INSERT INTO bps_com_salesorderobjetive SELECT bps_com_entity.entt_codsec, 0, GETDATE() FROM bps_com_entity WHERE entt_isCustomer = 1";

                clsConnection.executeQuery(queryString);
                populateDgv();
            }
        }

        private void dgvSaleOrderObj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmGuardar.Index)
            {
                bool psave = false;

                clsSaleOrderObjetive saleOrderObjetive = new clsSaleOrderObjetive(Convert.ToInt32(dgvSaleOrderObj.Rows[dgvSaleOrderObj.CurrentRow.Index].Cells[0].Value));

                saleOrderObjetive.objetiveNumber = Convert.ToInt32(dgvSaleOrderObj.Rows[dgvSaleOrderObj.CurrentRow.Index].Cells[3].Value);

                psave = saleOrderObjetive.save();

                if (psave == true)
                {
                    MessageBox.Show("¡Objetivo cargado con exito!", "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cmbEjecutiva_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEjecutiva.SelectedIndex != -1)
            {
                if (ejecutiva != cmbEjecutiva.SelectedItem.ToString())
                {
                    ejecutiva = cmbEjecutiva.SelectedItem.ToString();
                    lastChange = "ejecutiva";
                    populateDgv();
                }
                else
                {
                    ejecutiva = string.Empty;
                }
            }
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedIndex != -1)
            {
                if (cliente != cmbCliente.SelectedItem.ToString())
                {
                    cliente = cmbCliente.SelectedItem.ToString();
                    lastChange = "cliente";
                    populateDgv();
                }
                else
                {
                    cliente = string.Empty;
                }
            }
        }

        private void cmbEjecutiva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbEjecutiva.ResetText();
                ejecutiva = string.Empty;
                lastChange = string.Empty;
                populateDgv();
            }
        }

        private void cmbCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbCliente.ResetText();
                cliente = string.Empty;
                lastChange = string.Empty;
                populateDgv();
            }
        }

        private void dgvSaleOrderObj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }        
    }

    
}
