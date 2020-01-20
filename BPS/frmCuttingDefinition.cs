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
    public partial class frmCuttingDefinition : Form
    {
        DataSet DS = new DataSet();

        DataSet DS2 = new DataSet();

        DataSet DS3 = new DataSet();

        public frmCuttingDefinition()
        {
            InitializeComponent();
            getDataSet();
            PopulatedgvCuttingDefinition();
        }

        public void getDataSet()
        {
            DS = clsConnection.getDataSetResult("SELECT * FROM vwCuttingDefinition");
        }

        public void getDataSet2()
        {
            DS2 = clsConnection.getDataSetResult("SELECT * FROM vwCuttingDefinitionDetailAsigned WHERE fkCuttingDef = " + Math.Round(Convert.ToDouble(dgvCuttingDefinition.Rows[dgvCuttingDefinition.Rows.Count - 1].Cells[clmCodsec.Index].Value), 2));
        }

        public void getDataSet3(int number)
        {
            DS3 = clsConnection.getDataSetResult("CALL spCuttingDefinitionDetailByCutDef(" + number.ToString() + ")");
        }


        private void btnNew_Click(object sender, EventArgs e)
        {

            frmSaveNewCuttingDefinition generateNewReport = new frmSaveNewCuttingDefinition();
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        public void PopulatedgvCuttingDefinition()
        {
            dgvCuttingDefinition.Rows.Clear();
            
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvCuttingDefinition.Rows.Add();
                    dgvCuttingDefinition.Rows[dgvCuttingDefinition.Rows.Count - 1].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Codsec"]);
                    dgvCuttingDefinition.Rows[dgvCuttingDefinition.Rows.Count - 1].Cells[clmFilm.Index].Value = DS.Tables[0].Rows[i]["Película"].ToString();
                    dgvCuttingDefinition.Rows[dgvCuttingDefinition.Rows.Count - 1].Cells[clmQuantity.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Cantidad"]), 2);
                    dgvCuttingDefinition.Rows[dgvCuttingDefinition.Rows.Count - 1].Cells[clmMargin.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Margen"]), 2).ToString("0\\%");
                    dgvCuttingDefinition.Rows[dgvCuttingDefinition.Rows.Count - 1].Cells[clmEstimatedStart.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["InicioEstimado"]).ToShortDateString();
                    dgvCuttingDefinition.Rows[dgvCuttingDefinition.Rows.Count - 1].Cells[clmStatus.Index].Value = DS.Tables[0].Rows[i]["Estado"].ToString();
                    dgvCuttingDefinition.Rows[dgvCuttingDefinition.Rows.Count - 1].Cells[clmPlant.Index].Value = DS.Tables[0].Rows[i]["Planta"].ToString();
                    dgvCuttingDefinition.Rows[dgvCuttingDefinition.Rows.Count - 1].Cells[clmDefined.Index].Value = CutDefQuantity(Convert.ToInt32(DS.Tables[0].Rows[i]["Codsec"]));
                }
            }
        }

        private void dgvCuttingDefinition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmDefine.Index)
            {
                frmCuttingDefinitionDetail generateNewReport = new frmCuttingDefinitionDetail(Convert.ToInt32(DS.Tables[0].Rows[e.RowIndex]["Codsec"]),
                dgvCuttingDefinition.Rows[e.RowIndex].Cells[clmFilm.Index].Value.ToString(),
                Math.Round(Convert.ToDouble(dgvCuttingDefinition.Rows[e.RowIndex].Cells[clmQuantity.Index].Value), 2),
                dgvCuttingDefinition.Rows[e.RowIndex].Cells[clmStatus.Index].Value.ToString(),
                dgvCuttingDefinition.Rows[e.RowIndex].Cells[clmPlant.Index].Value.ToString(),
                Convert.ToDateTime(dgvCuttingDefinition.Rows[e.RowIndex].Cells[clmEstimatedStart.Index].Value));

                generateNewReport.StartPosition = FormStartPosition.CenterScreen;
                generateNewReport.MaximizeBox = false;
                generateNewReport.Show();
            }

            if (e.ColumnIndex == clmOVList.Index)
            {
                DS2 = clsConnection.getDataSetResult("SELECT * FROM vwCuttingDefinitionDetailOVList WHERE Definición = " + Math.Round(Convert.ToDouble(dgvCuttingDefinition.Rows[e.RowIndex].Cells[clmCodsec.Index].Value), 2));
                
                try
                {
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    app.Visible = true;
                    worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                    worksheet.Name = "Listado de OV";

                    for (int i = 1; i < DS2.Tables[0].Columns.Count + 1; i++)
                        worksheet.Cells[1, i] = DS2.Tables[0].Columns[i - 1].ToString();

                    for (int i = 0; i < DS2.Tables[0].Rows.Count; i++)
                    {
                        for (int j = 0; j < DS2.Tables[0].Columns.Count; j++)
                        {
                            if (DS2.Tables[0].Rows[i][j].ToString() != null)
                                worksheet.Cells[i + 2, j + 1] = DS2.Tables[0].Rows[i][j].ToString();
                        }
                    }
                    MessageBox.Show("Exportación Generada correctamente", "Listado de OV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Listado de OV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvCuttingDefinition_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String status = string.Empty;
            int codsec;
            string queryString = "";
            status = dgvCuttingDefinition.Rows[e.RowIndex].Cells[clmStatus.Index].Value.ToString();
            codsec = Convert.ToInt32(dgvCuttingDefinition.Rows[e.RowIndex].Cells[clmCodsec.Index].Value);


            if (e.ColumnIndex == clmStatus.Index)
            {
                if (status == "Abierta")
                {
                    dgvCuttingDefinition.Rows[e.RowIndex].Cells[clmStatus.Index].Value = "Cerrada";
                    btnNew.Focus();
                }
                else if (status == "Cerrada")
                {
                    dgvCuttingDefinition.Rows[e.RowIndex].Cells[clmStatus.Index].Value = "Archivada";
                    btnNew.Focus();
                }
                else
                {
                    dgvCuttingDefinition.Rows[e.RowIndex].Cells[clmStatus.Index].Value = "Abierta";
                    btnNew.Focus();
                }
            }

            status = dgvCuttingDefinition.Rows[e.RowIndex].Cells[clmStatus.Index].Value.ToString();

            try
            {
                {
                    queryString = "";
                    queryString += "UPDATE bps_prod_cuttingdefinition";
                    queryString += " SET ";
                    queryString += "cuttdef_status = '" + status + "' ";
                    queryString += " WHERE cuttdef_codsec = " + codsec.ToString();
                }
                clsConnection.executeQuery(queryString);

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCuttingDefinition.save");
            }

        }

        public int CutDefQuantity(int cutdef)
        {
            int quantity = 0;
            getDataSet3(cutdef);
            
            if (DS3.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS3.Tables[0].Rows.Count; i++)
                {
                  quantity = Convert.ToInt32(DS3.Tables[0].Rows[i]["TotalDefinido"]);

                }



            }
            return quantity;

        }
    }
}


