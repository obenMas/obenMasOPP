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
    public partial class frmTransportBySalesOrder : Form
    {
        clsEntity objCustomer = new clsEntity();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        List<clsTransportBySalesOrder> lstTransportBySalesOrder = new List<clsTransportBySalesOrder>();

        public frmTransportBySalesOrder()
        {
            InitializeComponent();
        }
        public frmTransportBySalesOrder(int salesOrderCodsec)
        {
            InitializeComponent();
            objSalesOrder.load(salesOrderCodsec);
        }

        private void fillTransportGrid()
        {
            lstTransportBySalesOrder = clsTransportBySalesOrder.getListBySalesOrder(objSalesOrder.codsec);
            dgvTransportBySalesOrder.Rows.Clear();
            for (int i = 0; i < lstTransportBySalesOrder.Count; i++)
            {
                dgvTransportBySalesOrder.Rows.Add();
                dgvTransportBySalesOrder.Rows[i].Cells[clmCodsec.Index].Value = lstTransportBySalesOrder[i].codsec;
                dgvTransportBySalesOrder.Rows[i].Cells[clmNumber.Index].Value = i + 1;
                dgvTransportBySalesOrder.Rows[i].Cells[clmTransportName.Index].Value = lstTransportBySalesOrder[i].transportName;
                clsTransport objTransport = new clsTransport(lstTransportBySalesOrder[i].fkTransport);
                dgvTransportBySalesOrder.Rows[i].Cells[clmWidth.Index].Value = objTransport.usefulWidth;
                dgvTransportBySalesOrder.Rows[i].Cells[clmHeight.Index].Value = objTransport.usefulHigh;
                dgvTransportBySalesOrder.Rows[i].Cells[clmDepth.Index].Value = objTransport.usefulLong;
                dgvTransportBySalesOrder.Rows[i].Cells[clmPalletInfo.Index].Value = global::BPS.Properties.Resources.pallet;
                dgvTransportBySalesOrder.Rows[i].Cells[clmDelete.Index].Value = global::BPS.Properties.Resources.cross;
            }
        }

        private void frmTransportBySalesOrder_Load(object sender, EventArgs e)
        {
            List<clsTransport> lstTransport = clsTransport.getList();

            for (int i = 0; i < lstTransport.Count; i++)
                cmbTransport.Items.Add(lstTransport[i]);

            if (objSalesOrder.codsec > 0)
            {
                lblNumber.Text = objSalesOrder.number;
                lblDate.Text = objSalesOrder.createdDate.ToString("dd/MM/yyyy HH:mm");
                lblStatus.Text = objSalesOrder.StatusName;
                lblCommercialCondition.Text = objSalesOrder.CommercialConditionName;
                objCustomer.load(objSalesOrder.fkEntity);
                lblCustomerName.Text = objCustomer.companyName;
                lblCountry.Text = objCustomer.countryName;
                lblCustomerId.Text = objCustomer.id;

                List<clsEntityAddress> lstAddress = clsEntityAddress.getListByEntity(objCustomer.codsec);

                if (lstAddress.Count > 0)
                    lblAddress.Text = lstAddress[0].address;
                else
                    lblAddress.Text = "";

                fillTransportGrid();
            }
        }

        private void cmbTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTransport.SelectedIndex != -1)
            {
                lblWidth.Text = ((clsTransport)cmbTransport.SelectedItem).usefulWidth.ToString();
                lblHeight.Text = ((clsTransport)cmbTransport.SelectedItem).usefulHigh.ToString();
                lblDepth.Text = ((clsTransport)cmbTransport.SelectedItem).usefulLong.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbTransport.SelectedIndex >= 0)
            {
                lstTransportBySalesOrder.Add(new clsTransportBySalesOrder());
                lstTransportBySalesOrder[lstTransportBySalesOrder.Count - 1].fkSalesOrder = objSalesOrder.codsec;
                lstTransportBySalesOrder[lstTransportBySalesOrder.Count - 1].fkTransport = ((clsTransport)cmbTransport.SelectedItem).codsec;
                lstTransportBySalesOrder[lstTransportBySalesOrder.Count - 1].save();
                fillTransportGrid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el tipo de transporte.", "Transportes por orden de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                cmbTransport.Focus();
            }
        }

        private void cmbTransport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsTransport> lstTransport = clsTransport.getList();
                cmbTransport.Items.Clear();
                for (int i = 0; i < lstTransport.Count; i++)
                    cmbTransport.Items.Add(lstTransport[i]); 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTransportBySalesOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmDelete.Index)
            {
                if (MessageBox.Show("Desea eliminar el transporte seleccionado?", "Transportes por orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    clsConnection.executeQuery("DELETE FROM bps_prod_transportbysalesorder WHERE tbso_codsec = " + dgvTransportBySalesOrder.Rows[e.RowIndex].Cells[clmCodsec.Index].Value.ToString());
                    fillTransportGrid();
                }
            }
        }
    }
}
