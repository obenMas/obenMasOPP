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
    public partial class frmCuttingDefinitionHistory : Form
    {
        DataSet DS = new DataSet();
        public frmCuttingDefinitionHistory()
        {
            InitializeComponent();
            getDataSet();
            PopulateDgvCuttingDefHistory();
            
        }

        public void getDataSet()
        {
            DS = clsConnection.getDataSetResult("SELECT * FROM CuttingDefinitionHistory");
        }

        public void PopulateDgvCuttingDefHistory()
        {
           dgvCuttingDefinitionHistory.Rows.Clear();
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvCuttingDefinitionHistory.Rows.Add();
                    dgvCuttingDefinitionHistory.Rows[dgvCuttingDefinitionHistory.Rows.Count - 1].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Codsec"]);
                    dgvCuttingDefinitionHistory.Rows[dgvCuttingDefinitionHistory.Rows.Count - 1].Cells[clmFilm.Index].Value = DS.Tables[0].Rows[i]["Película"].ToString();
                    dgvCuttingDefinitionHistory.Rows[dgvCuttingDefinitionHistory.Rows.Count - 1].Cells[clmQuantity.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Cantidad"]), 2);
                    dgvCuttingDefinitionHistory.Rows[dgvCuttingDefinitionHistory.Rows.Count - 1].Cells[clmMargin.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Margen"]), 2).ToString("0\\%");
                    dgvCuttingDefinitionHistory.Rows[dgvCuttingDefinitionHistory.Rows.Count - 1].Cells[clmEstimatedStart.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["InicioEstimado"]).ToShortDateString();
                    dgvCuttingDefinitionHistory.Rows[dgvCuttingDefinitionHistory.Rows.Count - 1].Cells[clmStatus.Index].Value = DS.Tables[0].Rows[i]["Estado"].ToString();
                    dgvCuttingDefinitionHistory.Rows[dgvCuttingDefinitionHistory.Rows.Count - 1].Cells[clmPlant.Index].Value = DS.Tables[0].Rows[i]["Planta"].ToString();
                }
            }

        }

        private void dgvCuttingDefinitionHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string queryString = "";
            int codsec = 0;

            if (e.ColumnIndex == clmReopen.Index)
            {
                codsec = Convert.ToInt32(dgvCuttingDefinitionHistory.Rows[e.RowIndex].Cells[clmCodsec.Index].Value);
                try
                {
                    {
                        queryString = "";
                        queryString += "UPDATE bps_prod_cuttingdefinition";
                        queryString += " SET ";
                        queryString += "cuttdef_status = 'Abierta' ";
                        queryString += " WHERE cuttdef_codsec = " + codsec.ToString();
                    }
                    //if (
                    clsConnection.executeQuery(queryString);//)
                        //flag = true;
                    //else
                        //flag = false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsCuttingDefinition.save");
                    //flag = false;
                }
                getDataSet();
                PopulateDgvCuttingDefHistory();
            }

            if(e.ColumnIndex == clmView.Index)
            {
                frmViewCuttingDefinitionDetail  generateNewReport = new frmViewCuttingDefinitionDetail(Convert.ToInt32(DS.Tables[0].Rows[e.RowIndex]["Codsec"]));
                generateNewReport.StartPosition = FormStartPosition.CenterScreen;
                generateNewReport.MaximizeBox = false;
                generateNewReport.Show();
            }
            
        }




    }
}
