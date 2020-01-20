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
    public partial class frmCuttingReport : Form
    {
        clsMachine objCutterMachine = new clsMachine();
        clsCuttingOrder objCuttingOrder = new clsCuttingOrder();
        List<clsCuttingOrder> lstCuttingOrder = new List<clsCuttingOrder>();
        List<clsMachine> lstMachine = clsMachine.getCutterMachineList();

        public frmCuttingReport()
        {
            InitializeComponent();
        }

        public frmCuttingReport(int codsec)
        {
            InitializeComponent();
            objCutterMachine.load(codsec, "Cutter");
        }

        private void frmCuttingReport_Load(object sender, EventArgs e)
        {
            lstCuttingOrder = clsCuttingOrder.getProgramedListByMachine(objCutterMachine.codsec);

            if (lstCuttingOrder.Count > 0)
            {
                for (int i = 0; i < lstCuttingOrder.Count; i++)
                {
                    lblCutterName.Text = lstCuttingOrder[i].machineName;
                }
                dgvCuttingOrder.Rows.Clear();
                for (int i = 0; i < lstCuttingOrder.Count; i++)
                {
                    dgvCuttingOrder.Rows.Add();
                    dgvCuttingOrder.Rows[i].Cells[clmCodSec.Index].Value = lstCuttingOrder[i].codsec;
                    dgvCuttingOrder.Rows[i].Cells[clmMachineName.Index].Value = lstCuttingOrder[i].machineName;
                    dgvCuttingOrder.Rows[i].Cells[clmFilmName.Index].Value = lstCuttingOrder[i].boppName;
                    dgvCuttingOrder.Rows[i].Cells[clmPosition.Index].Value = lstCuttingOrder[i].positions;
                    dgvCuttingOrder.Rows[i].Cells[clmStops.Index].Value = lstCuttingOrder[i].repetitions;
                }
            }
            else
                MessageBox.Show("No hay registros en esa cordadora", "Corte", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void dgvCuttingOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCuttingOrder.SelectedRows[0].Cells[clmCodSec.Index].Value != null || dgvCuttingOrder.SelectedRows[0].Cells[clmCodSec.Index].Value.ToString() != "")
            {
                objCuttingOrder.load(Convert.ToInt32(dgvCuttingOrder.SelectedRows[0].Cells[clmCodSec.Index].Value));
                dgvDetailsCutting.Rows.Clear();
                for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
                {
                    dgvDetailsCutting.Rows.Add();
                    dgvDetailsCutting.Rows[i].Cells[clmCodSecDetails.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                    dgvDetailsCutting.Rows[i].Cells[clmTotalCoil.Index].Value = Convert.ToString(objCuttingOrder.repetitions * objCuttingOrder.lstCuttingOrderDetail.Count);
                    dgvDetailsCutting.Rows[i].Cells[clmPositionDetails.Index].Value = i + 1;
                    if (objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail > 0)
                    {
                        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail);
                        clsSalesOrder objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);

                        dgvDetailsCutting.Rows[i].Cells[clmEntity.Index].Value = objSalesOrder.EntityName;
                        dgvDetailsCutting.Rows[i].Cells[clmOrdeNumber.Index].Value = objSalesOrder.number;
                    }
                    else
                    {
                        dgvDetailsCutting.Rows[i].Cells[clmEntity.Index].Value = "Producto en Stock";
                        dgvDetailsCutting.Rows[i].Cells[clmOrdeNumber.Index].Value = "---";
                    }
                    dgvDetailsCutting.Rows[i].Cells[clmProduct.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].product.code;
                    dgvDetailsCutting.Rows[i].Cells[clmwidth.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].width;
                    dgvDetailsCutting.Rows[i].Cells[clmlength.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].programmedLength;
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dgvCuttingOrder.SelectedRows[0].Cells[clmCodSec.Index].Value.ToString() != "" || dgvCuttingOrder.SelectedRows[0].Cells[clmCodSec.Index].Value != null)
            {

            }
            else
                MessageBox.Show("Seleccione una película para el reporte", "Corte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
