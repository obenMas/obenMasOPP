using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;
using System.Threading;
using Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;

namespace BPS
{
    public partial class frmEfficiencyCutExtruder : Form
    {
        List<clsEfficiencyCutExtruder> lstEfficiency = new List<clsEfficiencyCutExtruder>();

        bool executeFilter = true;
        string lotNumber = string.Empty;

        public frmEfficiencyCutExtruder()
        {
            InitializeComponent();
        }

        private void fillPalletInfo()
        {
            lstEfficiency = clsEfficiencyCutExtruder.getEfficiencySummaryPlus(lotNumber);
            
            double TotalConsuptionP = 0;
            double TotalConsuptionObs = 0;
            double TotalDecrease = 0;

            if (executeFilter == true)
            {   
                dgvDetails.Rows.Clear();

                for (int i = 0; i < lstEfficiency.Count; i++)
                {
                    TotalConsuptionP += Math.Round(lstEfficiency[i].consuption, 2, MidpointRounding.AwayFromZero);
                    TotalConsuptionObs += Math.Round(lstEfficiency[i].ConsuptionObs, 2, MidpointRounding.AwayFromZero);
                    
                    dgvDetails.Rows.Add();
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmcodsec.Index].Value = lstEfficiency[i].codsec;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmlotnumber.Index].Value = lotNumber.Substring(0, ((lotNumber).Length - 1));
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmmaincoil.Index].Value = GetMainCoilCode(lstEfficiency[i].MainCoilList, lstEfficiency[i].MainCoilValues);
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmnetweigth.Index].Value = lstEfficiency[i].mainCoilWeigth;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmconsuption.Index].Value = Math.Round(lstEfficiency[i].consuption, 2, MidpointRounding.AwayFromZero);
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmconsuptionobs.Index].Value = Math.Round(lstEfficiency[i].ConsuptionObs, 2, MidpointRounding.AwayFromZero);
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmdecrease.Index].Value = Math.Round(lstEfficiency[i].decrease, 2, MidpointRounding.AwayFromZero);
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmrefile.Index].Value = Math.Round(lstEfficiency[i].refile, 2, MidpointRounding.AwayFromZero);
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmendroller.Index].Value = Math.Round(lstEfficiency[i].endroller, 2, MidpointRounding.AwayFromZero);
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmwaste.Index].Value = Math.Round(lstEfficiency[i].waste, 2, MidpointRounding.AwayFromZero);
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmissplice.Index].Value = (lstEfficiency[i].splice == true) ? "Si" : "No";
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmefficiency.Index].Value = (lstEfficiency[i].splice == false) ? Math.Round((Math.Round(lstEfficiency[i].consuption, 2, MidpointRounding.AwayFromZero) / ((lstEfficiency[i].mainCoilWeigth <= 0) ? 1 : lstEfficiency[i].mainCoilWeigth) * 100), 2, MidpointRounding.AwayFromZero).ToString() + "%" : "0 %";
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmview.Index].Value = global::BPS.Properties.Resources.eye;
                    TotalDecrease += ((Math.Round(lstEfficiency[i].decrease, 2, MidpointRounding.AwayFromZero)) + (Math.Round(lstEfficiency[i].refile, 2, MidpointRounding.AwayFromZero)) + (Math.Round(lstEfficiency[i].endroller, 2, MidpointRounding.AwayFromZero)));
                }
            }

            lblTotalConsuptionP.Text = TotalConsuptionP.ToString();
            lblTotalConsuptionObs.Text = TotalConsuptionObs.ToString();
            lblDecrease.Text = TotalDecrease.ToString();
            lblEfficiency.Text = Math.Round((TotalConsuptionP / ((Convert.ToDouble(lblMainCoilWeigth.Text) <= 0) ? 1 : Convert.ToDouble(lblMainCoilWeigth.Text)) * 100), 2, MidpointRounding.AwayFromZero).ToString();
        }

        private string GetMainCoilCode(List<int> list, string mainCoilCode)
        {
            string code = string.Empty;
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    clsMainCoil objMainCoil = new clsMainCoil();
                    objMainCoil.load(list[i]);
                    code += objMainCoil.code + " - ";
                }
                return code.Substring(0, (code.Length - 3));
            }
            else
                return mainCoilCode;
        }

        private void frmEfficiencyCut_Load(object sender, EventArgs e)
        {
            PopulateLotNumber();
        }

        private void PopulateLotNumber()
        {
            List<clsFilmProductionPlan> lstFilmProductionOrder = new List<clsFilmProductionPlan>();
            lstFilmProductionOrder = clsFilmProductionPlan.getLotNumberEfficiency();
            cmbLotNumber.Items.Clear();
            for (int i = 0; i < lstFilmProductionOrder.Count; i++)
                cmbLotNumber.Items.Add(lstFilmProductionOrder[i]);
        }

        private void btnMainCoilClearFilters_Click(object sender, EventArgs e)
        {
            executeFilter = true;
            cmbLotNumber.SelectedIndex = -1;
            cmbLotNumber.Text = "";
            cmbLotNumber.SelectedItem = -1;
            txtWidth.Clear();
            dgvDetails.Rows.Clear();
        }

        private void cmbOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lotNumber = cmbLotNumber.Text + "0";
                lblFilm.Text = ((clsFilmProductionPlan)cmbLotNumber.SelectedItem).boppcode.ToString();
                fillMainCoilInfo(((clsFilmProductionPlan)cmbLotNumber.SelectedItem).fkProductionOrder);
                fillPalletInfo();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = this.Text;

                for (int i = 1; i < dgvDetails.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvDetails.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvDetails.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvDetails.Columns.Count; j++)
                    {
                        if (dgvDetails.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvDetails.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente... Por favor revisar el EXCEL", "Eficiencias", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eficiencias", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            if (txtWidth.Text.Length > 0)
            {
                lotNumber = txtWidth.Text + "0";
                lblFilm.Text = ((clsFilmProductionPlan)cmbLotNumber.SelectedItem).boppcode.ToString();
                fillMainCoilInfo(((clsFilmProductionPlan)cmbLotNumber.SelectedItem).fkProductionOrder);
                fillPalletInfo();
            }
        }

        private void cmbLotNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLotNumber.SelectedIndex > -1)
            {
                lotNumber = cmbLotNumber.Text + "0";
                lblFilm.Text = ((clsFilmProductionPlan)cmbLotNumber.SelectedItem).boppcode.ToString();
                fillMainCoilInfo(((clsFilmProductionPlan)cmbLotNumber.SelectedItem).fkProductionOrder);
                fillPalletInfo();
                
            }
        }

        private void fillMainCoilInfo(int fkproductionOrder)
        {
            double maincoilnetweigth = 0;
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            clsProductionOrderDetail objProductionOrderDetail = new clsProductionOrderDetail();
            objProductionOrderDetail.load(fkproductionOrder);
            lstMainCoil = clsMainCoil.getBoppMainCoilByProductionPlan(objProductionOrderDetail.fkFilmProductionPlan);
            lblMainCoilQuantity.Text = lstMainCoil.Count.ToString();

            for (int i = 0; i < lstMainCoil.Count; i++)
                maincoilnetweigth += lstMainCoil[i].netWeigth;
            
            lblMainCoilWeigth.Text = Math.Round(maincoilnetweigth, 2, MidpointRounding.AwayFromZero).ToString();
        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmview.Index)
            {
                frmEfficiencyDetails winDetails = new frmEfficiencyDetails(Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmcodsec.Index].Value), dgvDetails.Rows[e.RowIndex].Cells[clmmaincoil.Index].Value.ToString(), Convert.ToDouble(dgvDetails.Rows[e.RowIndex].Cells[clmnetweigth.Index].Value));
                winDetails.ShowDialog();
            }
        }
    }
}
