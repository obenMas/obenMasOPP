using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMainCoilList : Form
    {
        clsMainCoilQuality ObjMainCoilQuality = new clsMainCoilQuality();
        int fkplant = 0;

        public frmMainCoilList()
        {
            InitializeComponent();
        }

        public frmMainCoilList(int plant)
        {
            InitializeComponent();
            fkplant = plant;
        }

        private void btnMainCoilClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadMainCoilList()
        {
            DataSet lstMainCoil = new DataSet();
            List<clsFilter> lstFilter = new List<clsFilter>();

            if (chkFilm.Checked || chkLotNumber.Checked || chkDateRange.Checked)
            {

                if (cmbMainCoilListFilm.SelectedIndex >= 0)
                {

                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "mclq_fkBopp";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsBopp)cmbMainCoilListFilm.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }
                if (cmbMainCoilListBatch.SelectedIndex >= 0)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "mclq_lotNumber";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = cmbMainCoilListBatch.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }
                if (chkDateRange.Checked)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "mclq_initDate";
                    lstFilter[lstFilter.Count - 1].operation = "between";
                    lstFilter[lstFilter.Count - 1].value = dtpMainCoilInitDate.Value.ToString("dd/MM/yyyy HH:mm");
                    lstFilter[lstFilter.Count - 1].value2 = dtpMainCoilFinishedDate.Value.ToString("dd/MM/yyyy HH:mm");
                    lstFilter[lstFilter.Count - 1].dataType = "dateTime";
                }

                if(fkplant==0)
                {
                    lstMainCoil = clsMainCoil.getBoppMainCoilDSByFilter(lstFilter);
                }
                else if(fkplant==3)
                {
                    lstMainCoil = clsMainCoil.getBoppMainCoilDSByFilterC(lstFilter);
                }
                else
                {
                    lstMainCoil = clsMainCoil.getBoppMainCoilDSByFilterPL(lstFilter);
                }
            }
            else if (txtMainCoilCode.Text != "")
            {
                if (txtMainCoilCode.Text != "")
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "mclq_code";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = txtMainCoilCode.Text.Trim();
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }

                if (fkplant == 0)
                {
                    lstMainCoil = clsMainCoil.getBoppMainCoilDSByFilter(lstFilter);
                }
                else if (fkplant == 3)
                {
                    lstMainCoil = clsMainCoil.getBoppMainCoilDSByFilterC(lstFilter);
                }
                else
                {
                    lstMainCoil = clsMainCoil.getBoppMainCoilDSByFilterPL(lstFilter);
                }
            }
            else
                if (fkplant == 0)
                {
                    lstMainCoil = clsMainCoil.getActiveBoppMainCoilDSQuality();
                }
                else if (fkplant == 3)
                {
                    lstMainCoil = clsMainCoil.getActiveBoppMainCoilDSQuality(3);
                }
                else
                {
                    lstMainCoil = clsMainCoil.getActiveBoppMainCoilDSQuality(4);
                }

            dgvMainCoilList.Rows.Clear();

            for (int i = 0; i < lstMainCoil.Tables[0].Rows.Count; i++)
            {
                dgvMainCoilList.Rows.Add();
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListCodsec"].Value = Convert.ToInt32(lstMainCoil.Tables[0].Rows[i]["mclq_codsec"]); ;

                if (Convert.ToInt32(lstMainCoil.Tables[0].Rows[i]["mclq_fkBopp"]) > 0)
                {
                   // dgvMainCoilList.Rows[i].Cells[clmMainCoilListFilmType.Index].Value = "BOPP";
                    dgvMainCoilList.Rows[i].Cells["clmMainCoilListFilm"].Value = lstMainCoil.Tables[0].Rows[i]["mclq_boppCode"].ToString();
                }
                //else
                //{
                    //dgvMainCoilList.Rows[i].Cells[clmMainCoilListFilmType.Index].Value = "CAST";
                    //dgvMainCoilList.Rows[i].Cells["clmMainCoilListFilm"].Value = lstMainCoil[i].CastCode.ToString();
                //}

                dgvMainCoilList.Rows[i].Cells["clmMainCoilListCode"].Value = lstMainCoil.Tables[0].Rows[i]["mclq_code"].ToString();
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListBatch"].Value = lstMainCoil.Tables[0].Rows[i]["mclq_lotNumber"].ToString();
                //dgvMainCoilList.Rows[i].Cells["clmMainCoilListProductionOrder"].Value = lstMainCoil[i].ProductionOrderNumber.ToString();
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListLabRating"].Value = lstMainCoil.Tables[0].Rows[i]["mclq_labRating"].ToString();
                //dgvMainCoilList.Rows[i].Cells["clmMainCoilListAnalistRating"].Value = lstMainCoil[i].analistRating.ToString();
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListInitDate"].Value = Convert.ToDateTime(lstMainCoil.Tables[0].Rows[i]["mclq_initDate"]);
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListEndDate"].Value = Convert.ToDateTime(lstMainCoil.Tables[0].Rows[i]["mclq_endDate"]);
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListwi"].Value = Convert.ToInt32(lstMainCoil.Tables[0].Rows[i]["mclq_width"]);
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListwe"].Value = Convert.ToDouble(lstMainCoil.Tables[0].Rows[i]["mclq_netWeigth"]);
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListmet"].Value = Convert.ToDouble(lstMainCoil.Tables[0].Rows[i]["mclq_netlength"]);
                dgvMainCoilList.Rows[i].Cells[clmMainCoilListrep.Index].Value = clsGlobal.FillWithZeros(Convert.ToInt32(DateTime.Now.Subtract(Convert.ToDateTime(lstMainCoil.Tables[0].Rows[i]["mclq_endDate"])).TotalHours).ToString(), 2) + ":" + clsGlobal.FillWithZeros(DateTime.Now.Subtract(Convert.ToDateTime(lstMainCoil.Tables[0].Rows[i]["mclq_endDate"])).Minutes.ToString(), 2);
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListGra"].Value = Convert.ToDouble(lstMainCoil.Tables[0].Rows[i]["mclq_gramaje"]);;
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListcoftf"].Value = Convert.ToDouble(lstMainCoil.Tables[0].Rows[i]["mclq_coftf"]);
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListcofntf"].Value = Convert.ToDouble(lstMainCoil.Tables[0].Rows[i]["mclq_cofntf"]);
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListThikness"].Value = Convert.ToDouble(lstMainCoil.Tables[0].Rows[i]["mclq_thikness"]);
                List<double> lstDoubleValues = clsGlobal.getDoubleListFromString(lstMainCoil.Tables[0].Rows[i]["mclq_surfacetension"].ToString());
                if (lstDoubleValues.Count>0)
                {
                    dgvMainCoilList.Rows[i].Cells["clmsurfacetensiontf"].Value = lstDoubleValues[0];
                    dgvMainCoilList.Rows[i].Cells["clmsurfacetensionntf"].Value = lstDoubleValues[1];
                }
                
                dgvMainCoilList.Rows[i].Cells[clmMainCoilListQuality.Index].Value = global::BPS.Properties.Resources.quality;
                //if (lstMainCoil.Tables[0].Rows[i]["mcl_analistRating"].ToString() != "S/C")
                //    dgvMainCoilList.Rows[i].Cells[clmMainCoilListQualityReport.Index].Value = global::BPS.Properties.Resources.report;
                //else
                    dgvMainCoilList.Rows[i].Cells[clmMainCoilListQualityReport.Index].Value = global::BPS.Properties.Resources.reportOff;
                dgvMainCoilList.Rows[i].Cells[clmMainCoilListLabel.Index].Value = global::BPS.Properties.Resources.zone_label;
                dgvMainCoilList.Rows[i].Cells[clmMainCoilListDelete.Index].Value = global::BPS.Properties.Resources.cross;
                dgvMainCoilList.Rows[i].Cells[clmMainCoilSecundaryProperties.Index].Value = global::BPS.Properties.Resources.reportSalesorder;
                dgvMainCoilList.Rows[i].Cells[clmMainCoilLabel.Index].Value = global::BPS.Properties.Resources.printer;
            }

            
        }

        private void frmMainCoilList_Load(object sender, EventArgs e)
        {
            List<clsBopp> lstBoppFilm = clsBopp.getSimplifiedList();
            cmbMainCoilListFilm.Items.Clear();
            for (int i = 0; i < lstBoppFilm.Count; i++)
                cmbMainCoilListFilm.Items.Add(lstBoppFilm[i]);

            List<clsFilmProductionPlan> lstFilmProductionPlan = clsFilmProductionPlan.getListByLotNumeber();
            cmbMainCoilListBatch.Items.Clear();
            for (int i = 0; i < lstFilmProductionPlan.Count; i++)
                cmbMainCoilListBatch.Items.Add(lstFilmProductionPlan[i]);

            loadMainCoilList();
        }

        private void btnMainCoilFilters_Click(object sender, EventArgs e)
        {
            loadMainCoilList();
        }

        private void chkFilm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilm.Checked)
                grpbMainCoilFilm.Enabled = true;
            else
            {
                grpbMainCoilFilm.Enabled = false;
                cmbMainCoilListFilm.SelectedIndex = -1;
            }
        }

        private void chkLotNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLotNumber.Enabled)
                grpbMainCoilBatch.Enabled = true;
            else
            {
                grpbMainCoilBatch.Enabled = false;
                cmbMainCoilListBatch.SelectedIndex = -1;
            }
        }

        private void chkDateRange_CheckedChanged(object sender, EventArgs e)
        {
            grpbMainCoilDate.Enabled = chkDateRange.Enabled;
        }

        private void txtMainCoilCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadMainCoilList();
            }
        }

        private void btnMainCoilClearFilters_Click(object sender, EventArgs e)
        {
            chkLotNumber.Checked = false;
            chkFilm.Checked = false;
            chkDateRange.Checked = false;

            txtMainCoilCode.Text = "";

            loadMainCoilList();
        }

        private void dgvMainCoilList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmMainCoilListQuality.Index)
            {
                frmMainCoilQuality winMainCoilQuality = new frmMainCoilQuality(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value));
                winMainCoilQuality.MdiParent = this.MdiParent;
                winMainCoilQuality.StartPosition = FormStartPosition.Manual;
                winMainCoilQuality.Show();
                this.Close();
            }
            if (e.ColumnIndex == clmMainCoilListQualityReport.Index)
            {
                    frmMainCoilQualityReportPL winMainCoilQualityReport = new frmMainCoilQualityReportPL(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value));
                    winMainCoilQualityReport.MdiParent = this.MdiParent;
                    winMainCoilQualityReport.StartPosition = FormStartPosition.Manual;
                    winMainCoilQualityReport.Show();
                                //this.Close();
            }
            if (e.ColumnIndex == clmMainCoilListLabel.Index)
            {
                frmMainCoilLabel winMainCoilLabel = new frmMainCoilLabel(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value), GetDensity(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value)));
                winMainCoilLabel.StartPosition = FormStartPosition.Manual;
                winMainCoilLabel.MdiParent = this.MdiParent;
                winMainCoilLabel.Show();
            }
            if (e.ColumnIndex == clmMainCoilListDelete.Index)
            {
                MessageBox.Show("Esta acción no está disponible", "Listado de rollos madre", MessageBoxButtons.OK);
               
            }
            if (e.ColumnIndex == clmMainCoilLabel.Index)
            {
                if(fkplant==3)
                {
                    clsPrintLabels.printMainCoilRegisterOneLabel(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells["clmMainCoilListCodsec"].Value));
                }
                else if(fkplant==4)
                {
                    clsPrintLabels.printMainCoilRegisterOneLabelPL(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells["clmMainCoilListCodsec"].Value));
                }


            }
            /*if (e.ColumnIndex == clmMainCoilSecundaryProperties.Index)
            {
                frmMainCoilSecundaryProperties winMainCoilLabel = new frmMainCoilSecundaryProperties(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value));
                winMainCoilLabel.StartPosition = FormStartPosition.Manual;
                winMainCoilLabel.MdiParent = this.MdiParent;
                winMainCoilLabel.Show();
            }*/
        }

        private double GetDensity(int codsec)
        {
            double averagethikness = 0, averagegramaje = 0, totaldensity = 0, thikness = 0, gramaje = 0;
            int counterthikness = 0, countergramaje = 0;
            List<clsMainCoilLabel> lstMainCoilLabel = new List<clsMainCoilLabel>();
            ObjMainCoilQuality.loadByQuantity(codsec);
            lstMainCoilLabel = clsMainCoilLabel.getListByQuality(ObjMainCoilQuality.codsec);
            if (lstMainCoilLabel.Count > 0)
            {
                foreach (var item in lstMainCoilLabel)
                {
                    gramaje += item.maincoilgramaje;
                    countergramaje = lstMainCoilLabel.Count;
                }
                averagegramaje = gramaje / countergramaje;
            }
            lstMainCoilLabel.Clear();

            lstMainCoilLabel = clsMainCoilLabel.getListByQualitySp(codsec);
            if (lstMainCoilLabel.Count > 0)
            {
                for (int i = 0; i < lstMainCoilLabel.Count; i++)
                {
                    thikness += lstMainCoilLabel[i].thiknessaverage;
                    counterthikness += 1;
                }
                averagethikness = thikness / counterthikness;
            }

            totaldensity = averagegramaje / averagethikness;
            return Math.Round(totaldensity, 3);
        }

        private void cmbMainCoilListFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsBopp> lstBoppFilm = clsBopp.getSimplifiedList();
                cmbMainCoilListFilm.Items.Clear();
                for (int i = 0; i < lstBoppFilm.Count; i++)
                    cmbMainCoilListFilm.Items.Add(lstBoppFilm[i]);
            }
        }

        private void cmbMainCoilListBatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsFilmProductionPlan> lstFilmProductionPlan = clsFilmProductionPlan.getListByLotNumeber();
                cmbMainCoilListBatch.Items.Clear();
                for (int i = 0; i < lstFilmProductionPlan.Count; i++)
                    cmbMainCoilListBatch.Items.Add(lstFilmProductionPlan[i]);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadMainCoilList();
        }
    }
}