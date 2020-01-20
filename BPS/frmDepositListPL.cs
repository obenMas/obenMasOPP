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
    public partial class frmDepositListPL : Form
    {
        List<clsAymasDepot> palletList = new List<clsAymasDepot>();
        List<double> priceList = new List<double>();
        List<double> exchangeList = new List<double>();
        List<string> POList = new List<string>();
        List<string> plantList = new List<string>();
        List<string> custommerList = new List<string>();
        List<int> sodList = new List<int>();

        public frmDepositListPL(List<int> sodlist, List<double> prilist, List<double> exclist, List<string> purlist, List<string> plList, List<string> cstmList)
        {
            List<clsAymasDepot> aux = new List<clsAymasDepot>();
            InitializeComponent();
            for(int i=0;i<sodlist.Count;i++)
            {
                aux = clsAymasDepot.getAvailableListBySalesOrderDetailPL(sodlist[i]);
                for(int j=0;j<aux.Count;j++)
                {
                    palletList.Add(aux[j]);
                    priceList.Add(prilist[i]);
                    exchangeList.Add(exclist[i]);
                    POList.Add(purlist[i]);
                    plantList.Add(plList[i]);
                    custommerList.Add(cstmList[i]);
                    sodList.Add(sodlist[i]);
                }
            }
            populateDataGrid();
        }

        public void populateDataGrid()
        {
            for(int i=0;i<palletList.Count;i++)
            {
                dgvDepositListPL.Rows.Add();
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmCodsec.Index].Value = palletList[i].codsec;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmOrder.Index].Value = sodList[i];
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmPurchaseOrder.Index].Value = POList[i];
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmPrice.Index].Value = priceList[i] * exchangeList[i];
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmPlant.Index].Value = plantList[i];
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmCode.Index].Value = palletList[i].palletCode;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmFilm.Index].Value = palletList[i].film;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmWidth.Index].Value = palletList[i].width;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmDiameter.Index].Value = palletList[i].diameter;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmCore.Index].Value = palletList[i].core;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(palletList[i].weigth, 2);
                if (Convert.ToDouble(dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmNetWeight.Index].Value) > 999.99)
                {
                    dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(palletList[i].weigth, 2).ToString("0,000.00");
                }
                else
                {
                    dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(palletList[i].weigth, 2).ToString("00.00");
                }

                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmCustomer.Index].Value = custommerList[i];
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmSaleOrder.Index].Value = sodList[i];
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmOrigin.Index].Value = palletList[i].procedence;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmLocation.Index].Value = palletList[i].state;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmDate.Index].Value = palletList[i].date.ToShortDateString();
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmCheck.Index].Value = true;
                dgvDepositListPL.Rows[dgvDepositListPL.Rows.Count - 1].Cells[clmQualification.Index].Value = palletList[i].quality; 

            }
            txtTotalNetWeightPL.Text = CalculateTotalNetWeight().ToString();
        }

        public double CalculateTotalNetWeight()
        {
            double totalNetWeight = 0;
            for (int i = 0; i < dgvDepositListPL.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvDepositListPL.Rows[i].Cells[clmCheck.Index].Value))
                {
                    totalNetWeight += Math.Round(Convert.ToDouble(dgvDepositListPL.Rows[i].Cells[clmNetWeight.Index].Value), 2);
                    
                }
            }
            return totalNetWeight;

        }

        private void btnExportPL_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Listado de Depósito Pilar";

                for (int i = 2; i < dgvDepositListPL.Columns.Count + 1; i++)
                    worksheet.Cells[1, i - 1] = dgvDepositListPL.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvDepositListPL.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvDepositListPL.Rows[i].Cells[clmCheck.Index].Value))
                    {
                        for (int j = 1; j < dgvDepositListPL.Columns.Count - 1; j++)
                        {
                            if (dgvDepositListPL.Rows[i].Cells[j].Value != null)
                                worksheet.Cells[i + 2, j] = dgvDepositListPL.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }


                MessageBox.Show("Exportación Generada correctamente", "Listado de Depósito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Listado de Depósito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     

        }

        private void dgvDepositListPL_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCheck.Index)
            {
                double total = CalculateTotalNetWeight();
                if (total > 999.99)
                {
                    txtTotalNetWeightPL.Text = total.ToString("0,000.00");
                }
                else
                {
                    txtTotalNetWeightPL.Text = total.ToString("00.00");
                }

            }
        }

        private void dgvDepositListPL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCheck.Index)
            {
                txtTotalNetWeightPL.Focus();
            }
        }

        private void chkSelectAllPL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAllPL.Checked)
            {
                for (int i = 0; i < dgvDepositListPL.Rows.Count; i++)
                {
                    dgvDepositListPL.Rows[i].Cells[clmCheck.Index].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvDepositListPL.Rows.Count; i++)
                {
                    dgvDepositListPL.Rows[i].Cells[clmCheck.Index].Value = false;
                }
            }
        }

        private void btnPreshippingPL_Click(object sender, EventArgs e)
        {
            clsAymasDepot objpallet = new clsAymasDepot();
            List<clsAymasDepot> objPltList = new List<clsAymasDepot>();

            for (int i = 0; i < dgvDepositListPL.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvDepositListPL.Rows[i].Cells[clmCheck.Index].Value))
                {
                    objpallet = clsAymasDepot.getDetailByCode(dgvDepositListPL.Rows[i].Cells[clmCode.Index].Value.ToString());
                   
                    objPltList.Add(objpallet);

                }
            }
            frmPalletPreShippingPL winSystemConfig = new frmPalletPreShippingPL(objPltList);
            winSystemConfig.StartPosition = FormStartPosition.Manual;
            winSystemConfig.Show();
        }

    }
}
