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
    public partial class frmUnavailablePalletizedPallets : Form
    {

        DataSet DS = new DataSet();
        DataSet DS2 = new DataSet();

        public frmUnavailablePalletizedPallets(int order)
        {
            InitializeComponent();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwUnavailablePalletizedPallets WHERE sod_codsec = " + order);
            DS2 = clsConnection.getDataSetResult("SELECT * FROM vwUnavailablePalletizedPalletsPL WHERE sod_codsec = " + order);
            populateDgvCampana();
            populateDgvPilar();
        }


         public void populateDgvCampana()
        {
            double totalC = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
             {
                 for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvCampana.Rows.Add();
                    dgvCampana.Rows[i].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["sod_codsec"]);
                    dgvCampana.Rows[i].Cells[clmPalletCode.Index].Value = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    dgvCampana.Rows[i].Cells[clmNetWeigth.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]),2);
                    dgvCampana.Rows[i].Cells[clmWidth.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_width"]);
                    dgvCampana.Rows[i].Cells[clmDiameter.Index].Value = DS.Tables[0].Rows[i]["dtr_abbreviation"].ToString();
                    dgvCampana.Rows[i].Cells[clmCellar.Index].Value = DS.Tables[0].Rows[i]["cclr_name"].ToString();
                    dgvCampana.Rows[i].Cells[clmCreatedDate.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]).ToString("dd/MM/yyyy");
                    totalC += Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]), 2);
                }
             }
            txtTotalNetWeightC.Text = Math.Round(Convert.ToDouble(totalC),2).ToString();
        }

        public void populateDgvPilar()
         {
             double totalPl = 0;
             if (DS2.Tables.Count > 0 && DS2.Tables[0].Rows.Count > 0)
             {
                 for (int i = 0; i < DS2.Tables[0].Rows.Count; i++)
                 {
                     dgvPilar.Rows.Add();
                     dgvPilar.Rows[i].Cells[clmCodsecPL.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["fkSalesOrderDetail"]);
                     dgvPilar.Rows[i].Cells[clmPalletCodePL.Index].Value = DS2.Tables[0].Rows[i]["palletCode"].ToString();
                     dgvPilar.Rows[i].Cells[clmNetWeigthPL.Index].Value = Math.Round(Convert.ToDouble(DS2.Tables[0].Rows[i]["weigth"]), 2);
                     dgvPilar.Rows[i].Cells[clmWidthPL.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["width"]);
                     dgvPilar.Rows[i].Cells[clmDiameterPL.Index].Value = DS2.Tables[0].Rows[i]["diameter"].ToString();
                     dgvPilar.Rows[i].Cells[clmCellarPL.Index].Value = DS2.Tables[0].Rows[i]["state"].ToString();
                     dgvPilar.Rows[i].Cells[clmCreatedDatePL.Index].Value = Convert.ToDateTime(DS2.Tables[0].Rows[i]["date"]).ToString("dd/MM/yyyy");
                     totalPl += Math.Round(Convert.ToDouble(DS2.Tables[0].Rows[i]["weigth"]), 2);
                 }
             }
             txtNetWeightP.Text = Math.Round(Convert.ToDouble(totalPl), 2).ToString();
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
                worksheet.Name = "Paletizado No Disponible";

                for (int i = 1; i < dgvPilar.Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = dgvPilar.Columns[i -1].HeaderText;

                for (int i = 0; i < dgvPilar.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvPilar.Columns.Count; j++)
                    {
                        if (dgvPilar.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvPilar.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Paletizado No Disponible Pilar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Paletizado No Disponible Pilar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                worksheet.Name = "Paletizado No Disponible";

                for (int i = 1; i < dgvCampana.Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = dgvCampana.Columns[i -1].HeaderText;

                for (int i = 0; i < dgvCampana.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvCampana.Columns.Count; j++)
                    {
                        if (dgvCampana.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvCampana.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Paletizado No Disponible Campana", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Paletizado No Disponible Campana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
