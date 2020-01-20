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
    public partial class frmLotDetailByPalletList : Form
    {
        List<clsPallet> lstPresentedPallets = new List<clsPallet>();

        public frmLotDetailByPalletList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPalletCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clsSalesOrder objSalesOrder = clsSalesOrder.getDetailByNumber(txtPalletCode.Text);
                dgvLots.Rows.Clear();
                dgvPallets.Rows.Clear();
                lstPresentedPallets.Clear();

                for (int i = 0; i < objSalesOrder.lstSalesOrderDetail.Count; i++)
                {
                    List<clsPallet> lstPallets = clsPallet.getCompleteListBySalesOrderDetail(objSalesOrder.lstSalesOrderDetail[i].codsec);

                    for (int j = 0; j < lstPallets.Count; j++)
                    {
                        if (lstPallets[j].codsec != 0)
                        {
                            bool flgIsPalletInList = false;

                            for (int k = 0; k < dgvPallets.Rows.Count; k++)
                            {
                                if (dgvPallets.Rows[k].Cells[clmPalletCode.Index].Value.ToString() == lstPallets[j].code)
                                {
                                    flgIsPalletInList = true;
                                    break;
                                }
                            }

                            if (flgIsPalletInList == false)
                            {

                                dgvPallets.Rows.Add();
                                dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletCodsec.Index].Value = lstPallets[j].codsec;
                                dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletCode.Index].Value = lstPallets[j].code;
                                dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletCustomer.Index].Value = lstPallets[j].product.code;
                                dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletOrderNumber.Index].Value = lstPallets[j].palletNumber + " - " + lstPallets[j].lstCoil.Count;
                                dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletVisibility.Index].Value = global::BPS.Properties.Resources.eye;
                                dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletVisibilityValue.Index].Value = 1;
                                    
                                lstPresentedPallets.Add(lstPallets[j]);

                                bool flgInList = false;

                                for (int k = 0; k < lstPallets[j].lstCoil.Count; k++)
                                {
                                    flgInList = false;
                                    for (int l = 0; l < dgvLots.Rows.Count; l++)
                                    {
                                        if (dgvLots.Rows[l].Cells[clmLotNumber.Index].Value.ToString() == lstPallets[j].lstCoil[k].lotNumber)
                                        {
                                            flgInList = true;
                                            break;
                                        }
                                    }

                                    if (flgInList == false)
                                    {
                                        dgvLots.Rows.Add();
                                        dgvLots.Rows[dgvLots.Rows.Count - 1].Cells[clmLotNumber.Index].Value = lstPallets[j].lstCoil[k].lotNumber;
                                        dgvLots.Rows[dgvLots.Rows.Count - 1].Cells[clmLotProduct.Index].Value = lstPallets[j].lstCoil[k].ProductCode;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnAddPallet_Click(object sender, EventArgs e)
        {
            clsSalesOrder objSalesOrder = clsSalesOrder.getDetailByNumber(txtPalletCode.Text);
            dgvLots.Rows.Clear();
            dgvPallets.Rows.Clear();
            lstPresentedPallets.Clear();

            for (int i = 0; i < objSalesOrder.lstSalesOrderDetail.Count; i++)
            {
                List<clsPallet> lstPallets = clsPallet.getCompleteListBySalesOrderDetail(objSalesOrder.lstSalesOrderDetail[i].codsec);

                for (int j = 0; j < lstPallets.Count; j++)
                {
                    if (lstPallets[j].codsec != 0)
                    {
                        bool flgIsPalletInList = false;
                        
                        for (int k = 0; k < dgvPallets.Rows.Count; k++)
                        {
                            if (dgvPallets.Rows[k].Cells[clmPalletCode.Index].Value.ToString() == lstPallets[j].code)
                            {
                                flgIsPalletInList = true;
                                break;
                            }
                        }

                        if (flgIsPalletInList == false)
                        {

                            dgvPallets.Rows.Add();
                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletCodsec.Index].Value = lstPallets[j].codsec;
                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletCode.Index].Value = lstPallets[j].code;
                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletCustomer.Index].Value = lstPallets[j].product.code;
                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletOrderNumber.Index].Value = lstPallets[j].palletNumber + " - " + lstPallets[j].lstCoil.Count;
                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletVisibility.Index].Value = global::BPS.Properties.Resources.eye;
                            dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletVisibilityValue.Index].Value = 1;

                            lstPresentedPallets.Add(lstPallets[j]);

                            bool flgInList = false;

                            for (int k = 0; k < lstPallets[j].lstCoil.Count; k++)
                            {
                                for (int l = 0; l < dgvLots.Rows.Count;l++)
                                {
                                    if (dgvLots.Rows[l].Cells[clmLotNumber.Index].Value.ToString() == lstPallets[j].lstCoil[k].lotNumber)
                                    {
                                        flgInList = true;
                                        break;
                                    }
                                }

                                if (flgInList == false)
                                {
                                    dgvLots.Rows.Add();
                                    dgvLots.Rows[dgvLots.Rows.Count - 1].Cells[clmLotNumber.Index].Value = lstPallets[j].lstCoil[k].lotNumber;
                                    dgvLots.Rows[dgvLots.Rows.Count - 1].Cells[clmLotProduct.Index].Value = lstPallets[j].lstCoil[k].ProductCode;
                                }
                            }
                        }
                    }   
                }   
            }
        }

        private void frmLotDetailByPalletList_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bool flgInList = false;
            dgvLots.Rows.Clear();

            for (int i = 0; i < lstPresentedPallets.Count; i++)
            {
                if (dgvPallets.Rows[i].Cells[clmPalletVisibilityValue.Index].Value.ToString() == "1")
                {
                    for (int k = 0; k < lstPresentedPallets[i].lstCoil.Count; k++)
                    {
                        flgInList = false;
                        for (int l = 0; l < dgvLots.Rows.Count; l++)
                        {
                            if (dgvLots.Rows[l].Cells[clmLotNumber.Index].Value.ToString() == lstPresentedPallets[i].lstCoil[k].lotNumber)
                            {
                                flgInList = true;
                                break;
                            }
                        }

                        if (flgInList == false)
                        {
                            dgvLots.Rows.Add();
                            dgvLots.Rows[dgvLots.Rows.Count - 1].Cells[clmLotNumber.Index].Value = lstPresentedPallets[i].lstCoil[k].lotNumber;
                            dgvLots.Rows[dgvLots.Rows.Count - 1].Cells[clmLotProduct.Index].Value = lstPresentedPallets[i].lstCoil[k].ProductCode;
                        }
                    }
                }
            }
        }

        private void dgvPallets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmPalletVisibility.Index)
            {
                if (dgvPallets.Rows[e.RowIndex].Cells[clmPalletVisibilityValue.Index].Value.ToString() == "0")
                {
                    dgvPallets.Rows[e.RowIndex].Cells[clmPalletVisibility.Index].Value = global::BPS.Properties.Resources.eye;
                    dgvPallets.Rows[e.RowIndex].Cells[clmPalletVisibilityValue.Index].Value = 1;
                }
                else
                {
                    dgvPallets.Rows[e.RowIndex].Cells[clmPalletVisibility.Index].Value = global::BPS.Properties.Resources.clear;
                    dgvPallets.Rows[e.RowIndex].Cells[clmPalletVisibilityValue.Index].Value = 0;
                }
            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPallets.Rows.Count; i++)
            {
                if (chkSelectAll.Checked == true)
                {
                    dgvPallets.Rows[i].Cells[clmPalletVisibility.Index].Value = global::BPS.Properties.Resources.eye;
                    dgvPallets.Rows[i].Cells[clmPalletVisibilityValue.Index].Value = 1;
                    chkSelectNone.Checked = false;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPallets.Rows.Count; i++)
            {
                if (chkSelectNone.Checked == true)
                {
                    dgvPallets.Rows[i].Cells[clmPalletVisibility.Index].Value = global::BPS.Properties.Resources.clear;
                    dgvPallets.Rows[i].Cells[clmPalletVisibilityValue.Index].Value = 0;
                    chkSelectAll.Checked = false;
                }
            }
        }
    }
}
