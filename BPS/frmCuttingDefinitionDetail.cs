using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BPS.Bussiness;
using System.Windows.Forms;

namespace BPS
{
    public partial class frmCuttingDefinitionDetail : Form
    {
        DataSet DS = new DataSet();
        DataSet DS2 = new DataSet();
        public int priority = 0;
        private string last = string.Empty;

        public frmCuttingDefinitionDetail()
        {
            InitializeComponent();
        }

        public frmCuttingDefinitionDetail(int codsec, string film, double quantity, string status, string plant, DateTime date)
        {
            InitializeComponent();
            txtDefinitionNumber.Text = codsec.ToString();
            txtFilm.Text = film.ToString();
            txtTotalLot.Text = quantity.ToString();
            txtAvailable.Text = "0";
            txtStatus.Text = status.ToString();
            txtPlant.Text = plant.ToString();
            txtEstimatedStart.Text = date.ToString();
            getDataSet();
            populateDgvAsignable();
            getDataSet2();
            populateDgvAsigned();
        }

        public void getDataSet()
        {
            DS = clsConnection.getDataSetResult("SELECT * FROM vwCuttingDefinitionDetailAsignable WHERE Película ='" + txtFilm.Text.ToString() + "' AND Planta ='" + txtPlant.Text + "'");
        }

        public void getDataSet(string query)
        {
            DS = clsConnection.getDataSetResult(query);
        }

        public void getDataSet2()
        {
            DS2 = clsConnection.getDataSetResult("SELECT * FROM vwCuttingDefinitionDetailAsigned WHERE fkCuttingDef = " + txtDefinitionNumber.Text.ToString());
        }


        public void populateDgvAsignable()
        {
            List<string> executives = new List<string>();
            List<string> order = new List<string>();
            List<string> customers = new List<string>();
            double totalweigthAsignable = 0;

            cmbCustommer.Items.Clear();
            cmbExecutive.Items.Clear();
            cmbOrder.Items.Clear();

            dgvAsignable.Rows.Clear();
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvAsignable.Rows.Add();
                    dgvAsignable.Rows[dgvAsignable.Rows.Count - 1].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Codsec"]);
                    dgvAsignable.Rows[dgvAsignable.Rows.Count - 1].Cells[clmOrder.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Pedido"]);
                    dgvAsignable.Rows[dgvAsignable.Rows.Count - 1].Cells[clmCustommer.Index].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                    dgvAsignable.Rows[dgvAsignable.Rows.Count - 1].Cells[clmOCCustommer.Index].Value = DS.Tables[0].Rows[i]["OCCliente"].ToString();
                    dgvAsignable.Rows[dgvAsignable.Rows.Count - 1].Cells[clmExecutive.Index].Value = DS.Tables[0].Rows[i]["Ejecutiva"].ToString();
                    dgvAsignable.Rows[dgvAsignable.Rows.Count - 1].Cells[clmWidth.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Ancho"]);
                    dgvAsignable.Rows[dgvAsignable.Rows.Count - 1].Cells[clmDiameter.Index].Value = DS.Tables[0].Rows[i]["Diametro"].ToString();
                    dgvAsignable.Rows[dgvAsignable.Rows.Count - 1].Cells[clmCore.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Core"]);
                    dgvAsignable.Rows[dgvAsignable.Rows.Count - 1].Cells[clmCuttingPending.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteCorte"]), 2);
                    totalweigthAsignable += Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteCorte"]), 2);
                    dgvAsignable.Rows[dgvAsignable.Rows.Count - 1].Cells[clmDate.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaEntrega"]).ToShortDateString();
                    dgvAsignable.Rows[dgvAsignable.Rows.Count - 1].Cells[clmToRight.Index].Value = global::BPS.Properties.Resources.arrow_right;

                    if (!executives.Contains(DS.Tables[0].Rows[i]["Ejecutiva"].ToString()))
                        executives.Add(DS.Tables[0].Rows[i]["Ejecutiva"].ToString());

                    if (!order.Contains(DS.Tables[0].Rows[i]["Pedido"].ToString()))
                        order.Add(DS.Tables[0].Rows[i]["Pedido"].ToString());

                    if (!customers.Contains(DS.Tables[0].Rows[i]["Cliente"].ToString()))
                        customers.Add(DS.Tables[0].Rows[i]["Cliente"].ToString());
                }
                executives.Sort();
                order.Sort();
                customers.Sort();

                for (int j = 0; j < executives.Count; j++)
                {
                    cmbExecutive.Items.Add(executives[j]);
                }

                for (int j = 0; j < order.Count; j++)
                {
                    cmbOrder.Items.Add(order[j]);
                }

                for (int j = 0; j < customers.Count; j++)
                {
                    cmbCustommer.Items.Add(customers[j]);
                }

                if (cmbExecutive.Text != string.Empty)
                    cmbExecutive.SelectedIndex = 0;

                if (cmbOrder.Text != string.Empty)
                    cmbOrder.SelectedIndex = 0;

                if (cmbCustommer.Text != string.Empty)
                    cmbCustommer.SelectedIndex = 0;

            }
            txtTotalAsignable.Text = totalweigthAsignable.ToString();
        }

        public void populateDgvAsigned()
        {
            List<string> executives = new List<string>();
            List<string> order = new List<string>();
            List<string> customers = new List<string>();

            double totalweigthAsigned = 0;

            if(last!="Cliente")
            {
                cmbFiltroCliente.Items.Clear();
            }

            if (last != "Pedido")
            {
                cmbFiltroPedido.Items.Clear(); 
            }

            if(last != "Ejecutiva")
            {
                cmbFiltroEjecutiva.Items.Clear();
            }

            dgvAsigned.Rows.Clear();
            if (DS2.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS2.Tables[0].Rows.Count; i++)
                {
                    if (cmbFiltroPedido.SelectedIndex == -1 || cmbFiltroPedido.Items[cmbFiltroPedido.SelectedIndex].ToString() == DS2.Tables[0].Rows[i]["Pedido"].ToString())
                    {
                        if (cmbFiltroCliente.SelectedIndex == -1 || cmbFiltroCliente.Items[cmbFiltroCliente.SelectedIndex].ToString() == DS2.Tables[0].Rows[i]["Cliente"].ToString())
                        {
                            if (cmbFiltroEjecutiva.SelectedIndex == -1 || cmbFiltroEjecutiva.Items[cmbFiltroEjecutiva.SelectedIndex].ToString() == DS2.Tables[0].Rows[i]["Ejecutiva"].ToString())
                            {
                                dgvAsigned.Rows.Add();
                                dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[clmToLeftAsigned.Index].Value = global::BPS.Properties.Resources.arrow_left;
                                dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[clmCodsecAsigned.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["Codsec"]);
                                dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[clmOrderAsigned.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["Pedido"]);
                                dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[clmCustommerAsigned.Index].Value = DS2.Tables[0].Rows[i]["Cliente"].ToString();
                                dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[clmWidthAsigned.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["Ancho"]);
                                dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[clmDiameterAsigned.Index].Value = DS2.Tables[0].Rows[i]["Diametro"].ToString();
                                dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[clmCoreAsigned.Index].Value = DS2.Tables[0].Rows[i]["Core"].ToString();
                                dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[ejecutiva.Index].Value = DS2.Tables[0].Rows[i]["Ejecutiva"].ToString();
                                dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[clmQuantityAsigned.Index].Value = Convert.ToDouble(DS2.Tables[0].Rows[i]["Cantidad"]);
                    
                                dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[clmPriorityAsigned.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["Prioridad"]);

                                if (last != "Ejecutiva" && !executives.Contains(DS2.Tables[0].Rows[i]["Ejecutiva"].ToString()))
                                    executives.Add(DS2.Tables[0].Rows[i]["Ejecutiva"].ToString());

                                if (last != "Pedido" && !order.Contains(DS2.Tables[0].Rows[i]["Pedido"].ToString()))
                                    order.Add(DS2.Tables[0].Rows[i]["Pedido"].ToString());

                                if (last!="Cliente" && !customers.Contains(DS2.Tables[0].Rows[i]["Cliente"].ToString()))
                                    customers.Add(DS2.Tables[0].Rows[i]["Cliente"].ToString());
                            }
                        }
                        
                    }
                    

                    totalweigthAsigned += Convert.ToDouble(DS2.Tables[0].Rows[i]["Cantidad"]);
                }

                executives.Sort();
                order.Sort();
                customers.Sort();

                if (last != "Ejecutiva")
                {
                    for (int j = 0; j < executives.Count; j++)
                    {
                        cmbFiltroEjecutiva.Items.Add(executives[j]);
                    }
                }

                if (last != "Pedido")
                {
                    for (int j = 0; j < order.Count; j++)
                    {
                        cmbFiltroPedido.Items.Add(order[j]);
                    }
                }

                if (last != "Cliente")
                {
                    for (int j = 0; j < customers.Count; j++)
                    {
                        cmbFiltroCliente.Items.Add(customers[j]);
                    }
                }

            }
            txtTotalAsigned.Text = totalweigthAsigned.ToString();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Detalle de Definición de Corte";

                for (int i = 1; i < dgvAsignable.Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = dgvAsignable.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvAsignable.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvAsignable.Columns.Count - 1; j++)
                    {
                        if (dgvAsignable.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvAsignable.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Detalle de Definición de Corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Detalle de Definición de Corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void applyFilter()
        {
            bool first = false;
            string querystring = "SELECT * FROM vwCuttingDefinitionDetailAsignable WHERE Película ='" + txtFilm.Text.ToString() + "' AND Planta ='" + txtPlant.Text + "'";

            if (cmbExecutive.SelectedIndex != -1)
            {
                first = true;
                querystring += " AND Ejecutiva ='" + cmbExecutive.SelectedItem.ToString() + "' ";
            }

            if (cmbOrder.SelectedIndex != -1)
            {
                if (!first)
                {
                    first = true;
                    querystring += " AND ";
                }
                else
                {
                    querystring += "AND ";
                }
                querystring += "Pedido ='" + cmbOrder.SelectedItem.ToString() + "' ";
            }

            if (cmbCustommer.SelectedIndex != -1)
            {
                if (!first)
                {
                    first = true;
                    querystring += " AND ";
                }
                else
                {
                    querystring += "AND ";
                }
                querystring += "Cliente ='" + cmbCustommer.SelectedItem.ToString() + "' ";
            }
            getDataSet(querystring);
            populateDgvAsignable();
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            applyFilter();
        }

        private void btnDeleteFilter_Click(object sender, EventArgs e)
        {
            getDataSet();
            populateDgvAsignable();
            cmbCustommer.ResetText();
            cmbExecutive.ResetText();
            cmbOrder.ResetText();

            cmbCustommer.SelectedIndex = -1;
            cmbExecutive.SelectedIndex = -1;
            cmbOrder.SelectedIndex = -1;
        }

        private void dgvAsigned_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clsCuttingDefinitionDetail objcutdefd = new clsCuttingDefinitionDetail(Convert.ToInt32(dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[clmCodsecAsigned.Index].Value));
                objcutdefd.quantity = Convert.ToDouble(dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[clmQuantityAsigned.Index].Value);
                objcutdefd.save();
                label10.Focus();
                getDataSet2();
                populateDgvAsigned();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAsignable.Rows.Count; i++)
            {
                clsCuttingDefinitionDetail objcutdefd = new clsCuttingDefinitionDetail();
                objcutdefd.fkCuttingDefinition = Convert.ToInt32(txtDefinitionNumber.Text);
                objcutdefd.fkSaleOrderDetail = Convert.ToInt32(dgvAsignable.Rows[i].Cells[clmCodsec.Index].Value);
                objcutdefd.priority = 3;
                objcutdefd.quantity = Convert.ToDouble(dgvAsignable.Rows[i].Cells[clmCuttingPending.Index].Value);
                objcutdefd.save();
            }
            getDataSet();
            getDataSet2();
            populateDgvAsigned();
            populateDgvAsignable();
            priority = Convert.ToInt32(dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[clmPriorityAsigned.Index].Value);
        }



        private void dgvAsignable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtStatus.Text == "Abierta")
            {
                if (e.ColumnIndex == clmToRight.Index)
                {
                    clsCuttingDefinitionDetail objcutdefd = new clsCuttingDefinitionDetail();
                    objcutdefd.fkCuttingDefinition = Convert.ToInt32(txtDefinitionNumber.Text);
                    objcutdefd.fkSaleOrderDetail = Convert.ToInt32(dgvAsignable.Rows[e.RowIndex].Cells[clmCodsec.Index].Value);
                    objcutdefd.priority = 3;
                    objcutdefd.quantity = Convert.ToDouble(dgvAsignable.Rows[e.RowIndex].Cells[clmCuttingPending.Index].Value);
                    objcutdefd.save();
                    applyFilter();
                    getDataSet2();
                    populateDgvAsigned();
                    priority = Convert.ToInt32(dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[clmPriorityAsigned.Index].Value);
                }

            }
        }

        private void dgvAsigned_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            priority = Convert.ToInt32(dgvAsigned.Rows[e.RowIndex].Cells[clmPriorityAsigned.Index].Value);

            if (txtStatus.Text == "Abierta")
            {
                if (e.ColumnIndex == clmPriorityAsigned.Index)
                {
                    if (priority == 3)
                    {
                        dgvAsigned.Rows[e.RowIndex].Cells[clmPriorityAsigned.Index].Value = 1;
                        label10.Focus();
                        //priority = Convert.ToInt32(dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[clmPriorityAsigned.Index].Value);
                    }
                    else if (priority == 2)
                    {
                        dgvAsigned.Rows[e.RowIndex].Cells[clmPriorityAsigned.Index].Value = 3;
                        label10.Focus();
                        //priority = Convert.ToInt32(dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[clmPriorityAsigned.Index].Value);
                    }
                    else if (priority == 1)
                    {
                        dgvAsigned.Rows[e.RowIndex].Cells[clmPriorityAsigned.Index].Value = 2;
                        label10.Focus();
                        //priority = Convert.ToInt32(dgvAsigned.Rows[dgvAsigned.Rows.Count - 1].Cells[clmPriorityAsigned.Index].Value);
                    }

                    priority = Convert.ToInt32(dgvAsigned.Rows[e.RowIndex].Cells[clmPriorityAsigned.Index].Value);
                    label10.Focus();
                    clsCuttingDefinitionDetail objcutdefd = new clsCuttingDefinitionDetail(Convert.ToInt32(dgvAsigned.Rows[e.RowIndex].Cells[clmCodsecAsigned.Index].Value));
                    objcutdefd.priority = Convert.ToInt32(dgvAsigned.Rows[e.RowIndex].Cells[clmPriorityAsigned.Index].Value);
                    objcutdefd.save();
                    label10.Focus();
                }

                //getDataSet2();
                //populateDgvAsigned();

                if (e.ColumnIndex == clmToLeftAsigned.Index)
                {
                    clsCuttingDefinitionDetail.delete(Convert.ToInt32(dgvAsigned.Rows[e.RowIndex].Cells[clmCodsecAsigned.Index].Value));
                    applyFilter();
                    getDataSet2();
                    populateDgvAsigned();
                }
            }
        }

        private void dgvAsigned_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtStatus.Text == "Abierta")
            {
                if (e.ColumnIndex == clmToLeftAsigned.Index)
                {
                    clsCuttingDefinitionDetail.delete(Convert.ToInt32(dgvAsigned.Rows[e.RowIndex].Cells[clmCodsecAsigned.Index].Value));
                    applyFilter();
                    getDataSet2();
                    populateDgvAsigned();
                }
            }
        }

        private void btnDesassignAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvAsigned.Rows.Count; i++)
            {
                clsCuttingDefinitionDetail.delete(Convert.ToInt32(dgvAsigned.Rows[i].Cells[clmCodsecAsigned.Index].Value));

            }
            getDataSet();
            getDataSet2();
            populateDgvAsignable();
            populateDgvAsigned();
        }

        private void cmbFiltroPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            last = "Pedido";
            populateDgvAsigned();
        }

        private void cmbFiltroCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            last = "Cliente";
            populateDgvAsigned();
        }

        private void cmbFiltroEjecutiva_SelectedIndexChanged(object sender, EventArgs e)
        {
            last = "Ejecutiva";
            populateDgvAsigned();
        }

        private void cmbFiltroPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back)
            {
                cmbFiltroPedido.ResetText();
                cmbFiltroPedido.SelectedIndex = -1;
                last = string.Empty;
                populateDgvAsigned();
            }
                
        }

        private void cmbFiltroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroCliente.ResetText();
                cmbFiltroCliente.SelectedIndex = -1;
                last = string.Empty;
                populateDgvAsigned();
            }
        }

        private void cmbFiltroEjecutiva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFiltroEjecutiva.ResetText();
                cmbFiltroEjecutiva.SelectedIndex = -1;
                last = string.Empty;
                populateDgvAsigned();
            }
        }
    }
}

