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
    public partial class frmMetallizedOrderList : Form
    {
        public frmMetallizedOrderList()
        {
            InitializeComponent();
        }

        Boolean orderInProcess = false;
        Boolean orderClosed = false;

        private void loadGrid()
        {
            clsMetallizedOrder objMetallizedOrder = new clsMetallizedOrder();
            //List<clsCoilByCoil> lstCoilByCoil = new List<clsCoilByCoil>();
            List<clsMetallizedOrder> lstMetallizedOrder = new List<clsMetallizedOrder>();
            


            if (chkShowAll.Checked == true)
                lstMetallizedOrder = clsMetallizedOrder.getList();
            else
                lstMetallizedOrder = clsMetallizedOrder.getActiveOrderList();


            dgvMetallizedOrders.Rows.Clear();

            for (int i = 0; i < lstMetallizedOrder.Count; i++) 
            {
                /* SE COMENTO POR QUE 
                 * lstCoilByCoil = clsCoilByCoil.getDetailByMetallizedOrder(lstMetallizedOrder[i].codsec);
                
                if (lstCoilByCoil.Count == 0)                    
                    orderInProcess = false;
                else
                    orderInProcess = true;
                */
                //en fkStatus el 47 corresponde a orden de metalizado cerrada

                if(lstMetallizedOrder[i].fkStatus == 47)
                    orderClosed = true;
                else
                    orderClosed = false;

                dgvMetallizedOrders.Rows.Add();

                dgvMetallizedOrders.Rows[i].Cells[clmCodsec.Index].Value = lstMetallizedOrder[i].codsec;
                dgvMetallizedOrders.Rows[i].Cells[clmCreatedDate.Index].Value = lstMetallizedOrder[i].createdDate.ToString("dd/MM/yyyy HH:mm");
                dgvMetallizedOrders.Rows[i].Cells[clmNumber.Index].Value = lstMetallizedOrder[i].number;
                dgvMetallizedOrders.Rows[i].Cells[clmMetallizer.Index].Value = lstMetallizedOrder[i].MachineName;
                dgvMetallizedOrders.Rows[i].Cells[clmOpticDensity.Index].Value = Math.Round(lstMetallizedOrder[i].opticDensity, 2).ToString();                
                dgvMetallizedOrders.Rows[i].Cells[clmProductoFrom.Index].Value = lstMetallizedOrder[i].productFromCode;
                dgvMetallizedOrders.Rows[i].Cells[clmProductoTo.Index].Value = lstMetallizedOrder[i].productToCode;
                dgvMetallizedOrders.Rows[i].Cells[clmquantityCoils.Index].Value = lstMetallizedOrder[i].quantityCoils;
                dgvMetallizedOrders.Rows[i].Cells[clmStatus.Index].Value = lstMetallizedOrder[i].StatusName;
                dgvMetallizedOrders.Rows[i].Cells[clmCancel.Index].Value = global::BPS.Properties.Resources.cancel;
                dgvMetallizedOrders.Rows[i].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.blog;
            }
        }

        private void frmMetallizedOrderList_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brnAdd_Click(object sender, EventArgs e)
        {
            frmMetallizedOrder winMetallizedOrder = new frmMetallizedOrder();
            winMetallizedOrder.MdiParent = this.MdiParent;
            winMetallizedOrder.StartPosition = FormStartPosition.Manual;
            winMetallizedOrder.Show();
            this.Close();
        }

        private void dgvMetallizedOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmDetail.Index)
            {
                frmMetallizedOrderDetail winMetallizedOrderDetail = new frmMetallizedOrderDetail(Convert.ToInt32(dgvMetallizedOrders.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                winMetallizedOrderDetail.MdiParent = this.MdiParent;
                winMetallizedOrderDetail.StartPosition = FormStartPosition.Manual;
                winMetallizedOrderDetail.Show();
            }
            if (e.ColumnIndex == clmCancel.Index)
            {
                if (orderInProcess == false & orderClosed == false)
                {
                    clsStatus objStatus = new clsStatus();
                    objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Orden de metalizado", "Anulada");
                    clsMetallizedOrder objMetalizedOrder = new clsMetallizedOrder();
                    objMetalizedOrder.load(Convert.ToInt32(dgvMetallizedOrders.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                    objMetalizedOrder.fkStatus = objStatus.codsec;
                    objMetalizedOrder.save();
                    MessageBox.Show("La orden ha sido anulada exitosamente", "Orden Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    this.Close();
                }
                else
                {
                    if(orderClosed == true)
                        {
                        MessageBox.Show("La orden se encuentra cerrada. No podra Anularla", "Orden Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        this.Close();
                        }
                    else                    
                    {
                        MessageBox.Show("La orden se encuentra en proceso, debería cerrar la orden para no continuar con su cumplimiento.", "Orden Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }

            }
        }

        private void chkShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowAll.Checked == true)
            {
                loadGrid();
            }
            else
            {
                loadGrid();
            }
        }

    }
}
