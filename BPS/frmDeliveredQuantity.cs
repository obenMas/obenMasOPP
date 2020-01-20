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
    public partial class frmDeliveredQuantity : Form
    {
        DataSet DS = new DataSet();
        DataSet DS2 = new DataSet();
        DataSet DS3 = new DataSet();
        DataSet DS4 = new DataSet();
        double totalC = 0;
        double totalP = 0;


        public frmDeliveredQuantity(int sodcodsec)
        {
            InitializeComponent();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwDeliveredQuantityC WHERE Pedido = " + sodcodsec);
            DS4 = clsConnection.getDataSetResult("SELECT * FROM vwDeliveredQuantityC2 WHERE Pedido = " + sodcodsec);  
            DS2 = clsConnection.getDataSetResult("SELECT * FROM vwDeliveredQuantityP WHERE sod_codsec = " + sodcodsec);
            DS3 = clsConnection.getDataSetResult("SELECT * FROM vwDeliveredQuantityP2 WHERE Pedido = " + sodcodsec);
         
            populateDeliveredQuantityC();
            populateDeliveredQuantityC2();
            populateDeliveredQuantityPL();
            populateDeliveredQuantityPL2();

        }

        public void populateDeliveredQuantityC()
        {
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvDeliveredQuantityC.Rows.Add();
                    dgvDeliveredQuantityC.Rows[i].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Pedido"]);
                    dgvDeliveredQuantityC.Rows[i].Cells[clmPalletCode.Index].Value = DS.Tables[0].Rows[i]["Pallet"].ToString();
                    dgvDeliveredQuantityC.Rows[i].Cells[clmNetWeigth.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"]), 2);
                    dgvDeliveredQuantityC.Rows[i].Cells[clmWidth.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Ancho"]);
                    dgvDeliveredQuantityC.Rows[i].Cells[clmDiameter.Index].Value = DS.Tables[0].Rows[i]["Diametro"].ToString();
                    dgvDeliveredQuantityC.Rows[i].Cells[clmModifiedDate.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaDespacho"]).ToString("dd/MM/yyyy");
                    totalC += Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"]), 2);
                }
            }
            txtTotalNetWeightC.Text = Math.Round(Convert.ToDouble(totalC), 2).ToString();
        }

        public void populateDeliveredQuantityC2()
        {
            if (DS4.Tables.Count > 0 && DS4.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvDeliveredQuantityC.Rows.Add();
                    dgvDeliveredQuantityC.Rows[i].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS4.Tables[0].Rows[i]["Pedido"]);
                    dgvDeliveredQuantityC.Rows[i].Cells[clmPalletCode.Index].Value = DS4.Tables[0].Rows[i]["Pallet"].ToString();
                    dgvDeliveredQuantityC.Rows[i].Cells[clmNetWeigth.Index].Value = Math.Round(Convert.ToDouble(DS4.Tables[0].Rows[i]["PesoNeto"]), 2);
                    dgvDeliveredQuantityC.Rows[i].Cells[clmWidth.Index].Value = Convert.ToInt32(DS4.Tables[0].Rows[i]["Ancho"]);
                    dgvDeliveredQuantityC.Rows[i].Cells[clmDiameter.Index].Value = DS4.Tables[0].Rows[i]["Diametro"].ToString();
                    dgvDeliveredQuantityC.Rows[i].Cells[clmModifiedDate.Index].Value = Convert.ToDateTime(DS4.Tables[0].Rows[i]["FechaDespacho"]).ToString("dd/MM/yyyy");
                    totalC += Math.Round(Convert.ToDouble(DS4.Tables[0].Rows[i]["PesoNeto"]), 2);
                }
            }
            txtTotalNetWeightC.Text = Math.Round(Convert.ToDouble(totalC), 2).ToString();
        }


        public void populateDeliveredQuantityPL()
        {
            if (DS2.Tables.Count > 0 && DS2.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS2.Tables[0].Rows.Count; i++)
                {
                    dgvDeliveredQuantityPL.Rows.Add();
                    dgvDeliveredQuantityPL.Rows[i].Cells[clmCodsecPL.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["Pedido"]);
                    dgvDeliveredQuantityPL.Rows[i].Cells[clmRemitPL.Index].Value = Convert.ToDouble(DS2.Tables[0].Rows[i]["Remito"]);
                    dgvDeliveredQuantityPL.Rows[i].Cells[clmFilmPL.Index].Value = DS2.Tables[0].Rows[i]["Pelicula"].ToString();
                    dgvDeliveredQuantityPL.Rows[i].Cells[clmNetWeigthPL.Index].Value = Math.Round(Convert.ToDouble(DS2.Tables[0].Rows[i]["CantidadEntregada"]), 2);
                    dgvDeliveredQuantityPL.Rows[i].Cells[clmCreatedDatePL.Index].Value = Convert.ToDateTime(DS2.Tables[0].Rows[i]["Fecha"]).ToString("dd/MM/yyyy");
                    totalP += Math.Round(Convert.ToDouble(DS2.Tables[0].Rows[i]["CantidadEntregada"]), 2);
                }
            }
            txtNetWeightP.Text = Math.Round(Convert.ToDouble(totalP), 2).ToString();
        }

        public void populateDeliveredQuantityPL2()
        {
            if (DS3.Tables.Count > 0 && DS3.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS3.Tables[0].Rows.Count; i++)
                {
                    dgvDeliveredQuantityPL.Rows.Add();
                    dgvDeliveredQuantityPL.Rows[i].Cells[clmCodsecPL.Index].Value = Convert.ToInt32(DS3.Tables[0].Rows[i]["Pedido"]);
                    dgvDeliveredQuantityPL.Rows[i].Cells[clmRemitPL.Index].Value = Convert.ToDouble(DS3.Tables[0].Rows[i]["Remito"]);
                    dgvDeliveredQuantityPL.Rows[i].Cells[clmFilmPL.Index].Value = DS3.Tables[0].Rows[i]["Pelicula"].ToString();
                    dgvDeliveredQuantityPL.Rows[i].Cells[clmNetWeigthPL.Index].Value = Math.Round(Convert.ToDouble(DS3.Tables[0].Rows[i]["CantidadEntregada"]), 2);
                    dgvDeliveredQuantityPL.Rows[i].Cells[clmCreatedDatePL.Index].Value = Convert.ToDateTime(DS3.Tables[0].Rows[i]["Fecha"]).ToString("dd/MM/yyyy");
                    totalP += Math.Round(Convert.ToDouble(DS3.Tables[0].Rows[i]["CantidadEntregada"]), 2);
                }
            }
            txtNetWeightP.Text = Math.Round(Convert.ToDouble(totalP), 2).ToString();
        }

        private void btnExportC_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Cantidad Entregada Campana";

                for (int i = 1; i < dgvDeliveredQuantityC.Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = dgvDeliveredQuantityC.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvDeliveredQuantityC.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvDeliveredQuantityC.Columns.Count; j++)
                    {
                        if (dgvDeliveredQuantityC.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvDeliveredQuantityC.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Cantidad Entregada Campana", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cantidad Entregada Campana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportP_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Cantidad Entregada Pilar";

                for (int i = 1; i < dgvDeliveredQuantityPL.Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = dgvDeliveredQuantityPL.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvDeliveredQuantityPL.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvDeliveredQuantityPL.Columns.Count; j++)
                    {
                        if (dgvDeliveredQuantityPL.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvDeliveredQuantityPL.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Cantidad Entregada Pilar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cantidad Entregada Pilar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
