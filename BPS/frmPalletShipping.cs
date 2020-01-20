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
    public partial class frmPalletShipping : Form
    {
        List<clsPallet> lstPallets = new List<clsPallet>();
        clsSalesOrder objSalesOrder = new clsSalesOrder();

        public frmPalletShipping()
        {
            InitializeComponent();
        }

        //private void btnFilter_Click(object sender, EventArgs e)
        //{
        //    if (cmbInnig.Text == "Día")
        //    {
        //        TimeSpan tsInit = new TimeSpan(7, 30, 00);
        //        TimeSpan tsEnd = new TimeSpan(19, 30, 00);

        //        DateTime initDate = dtpDate.Value.Date + tsInit;
        //        DateTime endDate = dtpDate.Value.Date + tsEnd;

        //        lstPallets = clsPallet.getListByDate(initDate, endDate);
        //    }
        //    else
        //    {
        //        TimeSpan tsInit = new TimeSpan(19, 30, 00);
        //        TimeSpan tsEnd = new TimeSpan(7, 30, 00);

        //        DateTime initDate = dtpDate.Value.Date + tsInit;
        //        DateTime endDate = dtpDate.Value.AddDays(1).Date + tsEnd;

        //        lstPallets = clsPallet.getListByDate(initDate, endDate);
        //    }

        //    dgvPalletList.Rows.Clear();

        //    for (int i = 0; i < lstPallets.Count; i++)
        //    {
        //        dgvPalletList.Rows.Add();

        //        dgvPalletList.Rows[i].Cells[clmCodsec.Index].Value = lstPallets[i].codsec;
        //        dgvPalletList.Rows[i].Cells[clmNumber.Index].Value = (i + 1).ToString();
        //        dgvPalletList.Rows[i].Cells[clmProductCode.Index].Value = lstPallets[i].product.code;
        //        dgvPalletList.Rows[i].Cells[clmID.Index].Value = lstPallets[i].palletNumber.ToString() + " - " + lstPallets[i].lstCoil.Count.ToString();
        //        dgvPalletList.Rows[i].Cells[clmSalesOrderNumber.Index].Value = lstPallets[i].salesOrderNumber;
        //        dgvPalletList.Rows[i].Cells[clmWidth.Index].Value = Math.Round(lstPallets[i].product.width, 0);
        //        dgvPalletList.Rows[i].Cells[clmNetWeight.Index].Value = Math.Round(lstPallets[i].netWeight, 1);
        //        dgvPalletList.Rows[i].Cells[clmGrossWeight.Index].Value = Math.Round(lstPallets[i].grossWeight, 1);
        //        dgvPalletList.Rows[i].Cells[clmCustomer.Index].Value = lstPallets[i].customerName;
        //        dgvPalletList.Rows[i].Cells[clmLot.Index].Value = (lstPallets[i].lstCoil.Count > 0) ? lstPallets[i].lstCoil[0].lotNumber : "";
        //    }
        //}



        private void frmPalletList_Load(object sender, EventArgs e)
        {

        }

        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                objSalesOrder = clsSalesOrder.getDetailByNumber(txtNumber.Text);
                if (objSalesOrder.codsec > 0)
                {
                    txtNumber.Text = objSalesOrder.number;
                    lblCustomerName.Text = objSalesOrder.EntityName;

                    List<clsTransportBySalesOrder> lstTransportBySalesOrder = clsTransportBySalesOrder.getListBySalesOrder(objSalesOrder.codsec);

                    for (int i = 0; i < lstTransportBySalesOrder.Count; i++)
                        cmbTransport.Items.Add(lstTransportBySalesOrder[i]);
                }
                else
                    MessageBox.Show("No existe ese número de orden", "Ordenes de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstPallets = clsPallet.getListByTransport(((clsTransportBySalesOrder)cmbTransport.SelectedItem).codsec);

            dgvPalletList.Rows.Clear();
            for (int i = 0; i < lstPallets.Count; i++)
            {
                if (lstPallets[i].code == null)
                    lstPallets.RemoveAt(i);
            }

            for (int i = 0; i < lstPallets.Count; i++)
            {
                if (lstPallets[i].code == null)
                    lstPallets.RemoveAt(i);
            }

            for (int i = 0; i < lstPallets.Count; i++)
            {
                dgvPalletList.Rows.Add();
                dgvPalletList.Rows[i].Cells[clmCodsec.Index].Value = lstPallets[i].codsec;
                dgvPalletList.Rows[i].Cells[clmNumber.Index].Value = (i + 1).ToString();
                dgvPalletList.Rows[i].Cells[clmProductCode.Index].Value = lstPallets[i].product.code;
                dgvPalletList.Rows[i].Cells[clmID.Index].Value = lstPallets[i].palletNumber.ToString() + " - " + lstPallets[i].palletType.coilNumber.ToString();
                dgvPalletList.Rows[i].Cells[clmCode.Index].Value = lstPallets[i].code;
                dgvPalletList.Rows[i].Cells[clmSalesOrderNumber.Index].Value = lstPallets[i].salesOrderNumber;
                dgvPalletList.Rows[i].Cells[clmWidth.Index].Value = Math.Round(lstPallets[i].product.width, 0);
                dgvPalletList.Rows[i].Cells[clmNetWeight.Index].Value = Math.Round(lstPallets[i].netWeight, 1);
                dgvPalletList.Rows[i].Cells[clmGrossWeight.Index].Value = Math.Round(lstPallets[i].grossWeight, 1);

                if (lstPallets[i].statusName == "Activo")
                {
                    dgvPalletList.Rows[i].Cells[clmAction.Index].Value = global::BPS.Properties.Resources.clear;
                    dgvPalletList.Rows[i].Cells[clmActionToDo.Index].Value = "unshipped";
                }
                else if (lstPallets[i].statusName == "Abierto")
                {
                    dgvPalletList.Rows[i].Cells[clmAction.Index].Value = global::BPS.Properties.Resources.clear;
                    dgvPalletList.Rows[i].Cells[clmActionToDo.Index].Value = "unshipped";
                }
                else if (lstPallets[i].statusName == "Despachado")
                {
                    dgvPalletList.Rows[i].Cells[clmAction.Index].Value = global::BPS.Properties.Resources.delivery;
                    dgvPalletList.Rows[i].Cells[clmActionToDo.Index].Value = "shipped";
                }
            }
            txtPalletCode.Focus();
        }

        private void txtPalletCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clsPallet objPallet = clsPallet.getCompleteDetailByCode(txtPalletCode.Text, true);

                if (objPallet.codsec != 0)
                {
                    bool flgInList = false;

                    for (int i = 0; i < dgvPalletList.Rows.Count; i++)
                    {
                        if (dgvPalletList.Rows[i].Cells[clmCode.Index].Value.ToString() == objPallet.code)
                        {
                            dgvPalletList.Rows[i].Cells[clmAction.Index].Value = global::BPS.Properties.Resources.accept;
                            dgvPalletList.Rows[i].Cells[clmActionToDo.Index].Value = "toShip";
                            dgvPalletList.FirstDisplayedScrollingRowIndex = i;
                            txtPalletCode.Text = "";
                            flgInList = true;
                        }
                    }
                    if (flgInList == false)
                    {
                        MessageBox.Show("El pallet seleccionado no pertenece al packing list a ser despachado.", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
                else
                    MessageBox.Show("El código ingresado no corresponde a ningun pallet registrado en el sistema.", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se realizará el despacho de los pallets seleccionados, desea continuar?", "Registro de Bobina", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                for (int i = 0; i < dgvPalletList.Rows.Count; i++)
                {
                    if (dgvPalletList.Rows[i].Cells[clmActionToDo.Index].Value.ToString() == "toShip")
                    {
                        clsPallet.setPalletAsDelivered(Convert.ToInt32(dgvPalletList.Rows[i].Cells[clmCodsec.Index].Value));
                        
                    }
                }
                MessageBox.Show("Las bobinas seleccionadas han sido despachadas.", "Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
