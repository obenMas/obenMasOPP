using BPS.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BPS
{
    public partial class frmViewCuttingDefinitionDetail : Form
    {
        DataSet DS = new DataSet();
        DataSet DS2 = new DataSet();

        public frmViewCuttingDefinitionDetail(int number)
        {
            InitializeComponent();
            getDataSet(number);
            populateDgvViewCuttingDefDetail();
        }

        public void getDataSet(int codsec)
        {
            DS = clsConnection.getDataSetResult("SELECT * FROM CuttingDefinitionDetail WHERE fkCuttingDef = " + codsec);
        }

        public void getDataSet2(string query)
        {
            DS = clsConnection.getDataSetResult(query);
        }    
        

        public void populateDgvViewCuttingDefDetail()
        {
            double totalweigth = 0;
            List<string> order = new List<string>();
            List<string> customer = new List<string>();
            List<string> width = new List<string>();
            List<string> priority = new List<string>();

            cmbOrder.Items.Clear();
            cmbCustommer.Items.Clear();
            cmbWidth.Items.Clear();
            cmbPriority.Items.Clear();


            dgvViewCuttingDefDetail.Rows.Clear();
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvViewCuttingDefDetail.Rows.Add();
                    dgvViewCuttingDefDetail.Rows[dgvViewCuttingDefDetail.Rows.Count - 1].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Codsec"]);
                    dgvViewCuttingDefDetail.Rows[dgvViewCuttingDefDetail.Rows.Count - 1].Cells[clmfkCuttingDef.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["fkCuttingDef"]);
                    dgvViewCuttingDefDetail.Rows[dgvViewCuttingDefDetail.Rows.Count - 1].Cells[clmOrder.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Pedido"]);
                    dgvViewCuttingDefDetail.Rows[dgvViewCuttingDefDetail.Rows.Count - 1].Cells[clmCustommer.Index].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                    dgvViewCuttingDefDetail.Rows[dgvViewCuttingDefDetail.Rows.Count - 1].Cells[clmWidth.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Ancho"]);
                    dgvViewCuttingDefDetail.Rows[dgvViewCuttingDefDetail.Rows.Count - 1].Cells[clmDiameter.Index].Value = DS.Tables[0].Rows[i]["Diametro"].ToString();
                    dgvViewCuttingDefDetail.Rows[dgvViewCuttingDefDetail.Rows.Count - 1].Cells[clmCore.Index].Value = DS.Tables[0].Rows[i]["Core"].ToString();
                    dgvViewCuttingDefDetail.Rows[dgvViewCuttingDefDetail.Rows.Count - 1].Cells[clmQuantity.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["Cantidad"]);
                    dgvViewCuttingDefDetail.Rows[dgvViewCuttingDefDetail.Rows.Count - 1].Cells[clmPriority.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Prioridad"]);
                    totalweigth += Convert.ToDouble(DS.Tables[0].Rows[i]["Cantidad"]);

                    if (!order.Contains(DS.Tables[0].Rows[i]["Pedido"].ToString()))
                        order.Add(DS.Tables[0].Rows[i]["Pedido"].ToString());

                    if (!customer.Contains(DS.Tables[0].Rows[i]["Cliente"].ToString()))
                        customer.Add(DS.Tables[0].Rows[i]["Cliente"].ToString());

                    if (!width.Contains(DS.Tables[0].Rows[i]["Ancho"].ToString()))
                        width.Add(DS.Tables[0].Rows[i]["Ancho"].ToString());


                    if (!priority.Contains(DS.Tables[0].Rows[i]["Prioridad"].ToString()))
                        priority.Add(DS.Tables[0].Rows[i]["Prioridad"].ToString());
                }
                order.Sort();
                customer.Sort();
                width.Sort();
                priority.Sort();

                for (int j = 0; j < order.Count; j++)
                {
                    cmbOrder.Items.Add(order[j]);
                }

                for (int j = 0; j < customer.Count; j++)
                {
                    cmbCustommer.Items.Add(customer[j]);
                }

                for (int j = 0; j < width.Count; j++)
                {
                    cmbWidth.Items.Add(width[j]);
                }
                
                for (int j = 0; j < priority.Count; j++)
                {
                    cmbPriority.Items.Add(priority[j]);
                }

                if (cmbOrder.Text != string.Empty)
                    cmbOrder.SelectedIndex = 0;

                if (cmbCustommer.Text != string.Empty)
                    cmbCustommer.SelectedIndex = 0;

                if (cmbWidth.Text != string.Empty)
                    cmbWidth.SelectedIndex = 0;

                if (cmbPriority.Text != string.Empty)
                    cmbPriority.SelectedIndex = 0;
            }
            txtTotal.Text = totalweigth.ToString();
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

                for (int i = 1; i < dgvViewCuttingDefDetail.Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = dgvViewCuttingDefDetail.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvViewCuttingDefDetail.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvViewCuttingDefDetail.Columns.Count; j++)
                    {
                        if (dgvViewCuttingDefDetail.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvViewCuttingDefDetail.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Detalle de Definición de Corte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Detalle de Definición de Corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFilter_Click(object sender, EventArgs e)
        {
            getDataSet(Convert.ToInt32(DS.Tables[0].Rows[dgvViewCuttingDefDetail.Rows.Count - 1]["fkCuttingDef"]));
            populateDgvViewCuttingDefDetail();
            cmbOrder.ResetText();
            cmbCustommer.ResetText();
            cmbWidth.ResetText();
            cmbPriority.ResetText();

            cmbOrder.SelectedIndex = -1;
            cmbCustommer.SelectedIndex = -1;
            cmbWidth.SelectedIndex = -1;
            cmbPriority.SelectedIndex = -1;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            applyFilter();
        }

        private void applyFilter()
        {
            int fkCuttingDef = 0;
            bool first = false;
            fkCuttingDef = Convert.ToInt32(DS.Tables[0].Rows[dgvViewCuttingDefDetail.Rows.Count - 1]["fkCuttingDef"]);
            string querystring = "SELECT * FROM CuttingDefinitionDetail WHERE fkCuttingDef = " + fkCuttingDef;

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
                querystring += "Pedido = " + cmbOrder.SelectedItem.ToString();
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

            if (cmbWidth.SelectedIndex != -1)
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
                querystring += "Ancho = " + cmbWidth.SelectedItem.ToString();
            }

            if (cmbPriority.SelectedIndex != -1)
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
                querystring += "Prioridad ='" + cmbPriority.SelectedItem.ToString() + "' ";
            }
            getDataSet2(querystring);
            populateDgvViewCuttingDefDetail();
        }
    }
}
