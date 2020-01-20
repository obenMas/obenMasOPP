using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using BPS.Reporting.Metal.MainCoilQualityReportMetal;
using BPS.Reporting.Metal.MainCoilQualityReportMetalCut;


namespace BPS.Lite
{
    public partial class frmMainCoilMetalList : Form
    {
        clsMainCoilQualityMetal ObjMainCoilQualityMetal = new clsMainCoilQualityMetal();

        public frmMainCoilMetalList()
        {
            InitializeComponent();
        }

        private void btnMainCoilClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadMainCoilList(string filter)
        {
            try
            {
                if (filter == string.Empty)
                {
                    List<clsMainCoilMetal> lstMainCoilMetal = new List<clsMainCoilMetal>();
                    lstMainCoilMetal = clsMainCoilMetal.getActiveMainCoilMetal();

                    dgvMainCoilList.Rows.Clear();

                    for (int i = 0; i < lstMainCoilMetal.Count; i++)
                    {
                        dgvMainCoilList.Rows.Add();
                        dgvMainCoilList.Rows[i].Cells[clmMainCoilListCodsec.Index].Value = lstMainCoilMetal[i].codsec.ToString();
                        dgvMainCoilList.Rows[i].Cells[clmMainCoilListFilmType.Index].Value = "BOPP";
                        dgvMainCoilList.Rows[i].Cells[clmMainCoilListFilm.Index].Value = lstMainCoilMetal[i].BoppToCode.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListCode"].Value = lstMainCoilMetal[i].mcode.ToString();
                        dgvMainCoilList.Rows[i].Cells[clmcode.Index].Value = lstMainCoilMetal[i].bcode.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListBatch"].Value = lstMainCoilMetal[i].lotNumber.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListProductionOrder"].Value = lstMainCoilMetal[i].origin.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListLabRating"].Value = lstMainCoilMetal[i].labRating.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListAnalistRating"].Value = lstMainCoilMetal[i].analistRating.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListInitDate"].Value = lstMainCoilMetal[i].createdDate.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListEndDate"].Value = lstMainCoilMetal[i].modifiedDate.ToString();
                        dgvMainCoilList.Rows[i].Cells[clmMainCoilListQuality.Index].Value = global::BPS.Lite.Properties.Resources.quality;
                        dgvMainCoilList.Rows[i].Cells[clmMainCoilListQualityReport.Index].Value = global::BPS.Lite.Properties.Resources.report;
                        dgvMainCoilList.Rows[i].Cells[clmMainCoilListDelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                        dgvMainCoilList.Rows[i].Cells[clmMainCoilSecundaryProperties.Index].Value = global::BPS.Lite.Properties.Resources.reportOff;
                    }

                    if (clsGlobal.LoggedUser.fkRole == 4)
                    {
                        dgvMainCoilList.Columns[clmMainCoilListDelete.Index].Visible = false;
                        dgvMainCoilList.Columns[clmMainCoilListQuality.Index].Visible = false;
                    }
                }
                else
                {
                    List<clsMainCoilMetal> lstMainCoilMetal = new List<clsMainCoilMetal>();
                    lstMainCoilMetal = clsMainCoilMetal.getActiveMainCoilMetalByFilter(filter);

                    dgvMainCoilList.Rows.Clear();

                    for (int i = 0; i < lstMainCoilMetal.Count; i++)
                    {
                        dgvMainCoilList.Rows.Add();
                        dgvMainCoilList.Rows[i].Cells[clmMainCoilListCodsec.Index].Value = lstMainCoilMetal[i].codsec.ToString();
                        dgvMainCoilList.Rows[i].Cells[clmMainCoilListFilmType.Index].Value = "BOPP";
                        dgvMainCoilList.Rows[i].Cells[clmMainCoilListFilm.Index].Value = lstMainCoilMetal[i].BoppToCode.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListCode"].Value = lstMainCoilMetal[i].mcode.ToString();
                        dgvMainCoilList.Rows[i].Cells[clmcode.Index].Value = lstMainCoilMetal[i].bcode.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListBatch"].Value = lstMainCoilMetal[i].lotNumber.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListProductionOrder"].Value = lstMainCoilMetal[i].origin.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListLabRating"].Value = lstMainCoilMetal[i].labRating.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListAnalistRating"].Value = lstMainCoilMetal[i].analistRating.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListInitDate"].Value = lstMainCoilMetal[i].createdDate.ToString();
                        dgvMainCoilList.Rows[i].Cells["clmMainCoilListEndDate"].Value = lstMainCoilMetal[i].modifiedDate.ToString();
                        dgvMainCoilList.Rows[i].Cells[clmMainCoilListQuality.Index].Value = global::BPS.Lite.Properties.Resources.quality;
                        if (lstMainCoilMetal[i].analistRating != "S/C")
                            dgvMainCoilList.Rows[i].Cells[clmMainCoilListQualityReport.Index].Value = global::BPS.Lite.Properties.Resources.report;
                        else
                            dgvMainCoilList.Rows[i].Cells[clmMainCoilListQualityReport.Index].Value = global::BPS.Lite.Properties.Resources.reportOff;
                        dgvMainCoilList.Rows[i].Cells[clmMainCoilListDelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                        dgvMainCoilList.Rows[i].Cells[clmMainCoilSecundaryProperties.Index].Value = global::BPS.Lite.Properties.Resources.reportOff;
                    }

                    if (clsGlobal.LoggedUser.fkRole == 4)
                    {
                        dgvMainCoilList.Columns[clmMainCoilListDelete.Index].Visible = false;
                        dgvMainCoilList.Columns[clmMainCoilListQuality.Index].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void frmMainCoilMetalList_Load(object sender, EventArgs e)
        {
            loadMainCoilList(string.Empty);
        }

        private void txtMainCoilCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loadMainCoilList(txtMainCoilCode.Text);
        }

        private void dgvMainCoilList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmMainCoilListQualityReport.Index)
            {
                frmMainCoilQualityReportMetal winMainCoilQualityReport = new frmMainCoilQualityReportMetal(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value), clsGlobal.password);
                winMainCoilQualityReport.MdiParent = this.MdiParent;
                winMainCoilQualityReport.StartPosition = FormStartPosition.Manual;
                winMainCoilQualityReport.Show();
            }
            if (e.ColumnIndex == clmMainCoilSecundaryProperties.Index)
            {
                frmMainCoilQualityReportMetalCut winMainCoilQualityReport = new frmMainCoilQualityReportMetalCut(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value), clsGlobal.password);
                winMainCoilQualityReport.MdiParent = this.MdiParent;
                winMainCoilQualityReport.StartPosition = FormStartPosition.Manual;
                winMainCoilQualityReport.Show();
            }
        }
    }
}