using System;
using System.Drawing;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMetallizedProductionOrdenList : Form
    {
        public frmMetallizedProductionOrdenList()
        {
            InitializeComponent();
            PopulateList();
        }

        private void PopulateList()
        {
            var listMetallized = clsMetallizedOrder.getListSummary();
            dgvProductionOrderList.Rows.Clear();
            int pos = 0;
            foreach (var item in listMetallized)
            {
                dgvProductionOrderList.Rows.Add();
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderListCodsec.Index].Value = item.codsec;
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderListFkFilmProductionOrder.Index].Value = item.fkFilmProduction;
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderListFilmType.Index].Value = "BOPP";
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderNumber.Index].Value = item.lotnumber.ToString().ToUpper();
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderBase.Index].Value = item.productFromName.ToUpper();
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderMetal.Index].Value = item.productToName.ToUpper();
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderWidths.Index].Value = item.ordenation.ToString();
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderCoil.Index].Value = item.quantityCoils.ToString();
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderQuantity.Index].Value = Math.Round(item.totalweigth, 2, MidpointRounding.AwayFromZero).ToString();
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderStatus.Index].Value = item.StatusName;

                if (item.StatusName == "Proceso")
                {
                    for (int j = 0; j < dgvProductionOrderList.ColumnCount; j++)
                        dgvProductionOrderList.Rows[pos].Cells[j].Style.BackColor = Color.Orange;
                }

                pos++;
            }
        }

        private void btnProductionOrderClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductionOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMetallizedProductionOrderDetails winProductionOrderDetails = new frmMetallizedProductionOrderDetails(Convert.ToInt32(dgvProductionOrderList.SelectedRows[0].Cells[clmProductionOrderListCodsec.Index].Value));
            winProductionOrderDetails.MdiParent = this.MdiParent;
            winProductionOrderDetails.StartPosition = FormStartPosition.Manual;
            winProductionOrderDetails.Show();
        }

        private void txtLotNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PopulateListByLote(txtLotNumber.Text.ToUpper());
        }

        private void PopulateListByLote(string lotNumber)
        {
            var listMetallized = clsMetallizedOrder.getListSummaryByLote(lotNumber);
            dgvProductionOrderList.Rows.Clear();
            int pos = 0;
            foreach (var item in listMetallized)
            {
                dgvProductionOrderList.Rows.Add();
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderListCodsec.Index].Value = item.codsec;
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderListFkFilmProductionOrder.Index].Value = item.fkFilmProduction;
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderListFilmType.Index].Value = "BOPP";
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderNumber.Index].Value = item.lotnumber.ToString().ToUpper();
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderBase.Index].Value = item.productFromName.ToUpper();
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderMetal.Index].Value = item.productToName.ToUpper();
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderWidths.Index].Value = item.ordenation.ToString();
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderCoil.Index].Value = item.quantityCoils.ToString();
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderQuantity.Index].Value = Math.Round(item.totalweigth, 2, MidpointRounding.AwayFromZero).ToString();
                dgvProductionOrderList.Rows[pos].Cells[clmProductionOrderStatus.Index].Value = item.StatusName;

                if (item.StatusName == "Proceso")
                {
                    for (int j = 0; j < dgvProductionOrderList.ColumnCount; j++)
                        dgvProductionOrderList.Rows[pos].Cells[j].Style.BackColor = Color.Orange;
                }

                pos++;
            }
        }
    }
}