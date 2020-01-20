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
    public partial class frmPalletPreShippingPL : Form
    {
         public string procedence = string.Empty;

        public int codsec = 0, totalcoil = 0;

        public double totalweigth = 0;

        public bool flgValidate = true;

        public frmPalletPreShippingPL()
        {
            InitializeComponent();
        }

        public frmPalletPreShippingPL(int codsec)
        {
            InitializeComponent();
            dtpProgrammedDatePL.Value = dtpProgrammedDatePL.Value.AddDays(1); //cambia el dateTimePicker al dia siguiente del actual.
            this.codsec = codsec;
            if (codsec <= 0)
            {
                lblNumber.Text = (clsPalletPreShippingPL.GetOrdinalNumber() + 1).ToString();
                FillDataSalesOrder(0);
            }
            else
            {
                clsPalletPreShippingPL ObjPalletPreShippingPL = new clsPalletPreShippingPL(codsec);
                lblNumber.Text = clsPalletPreShippingPL.GetOrdinalNumber().ToString();
                //FindDataSalesOrder(ObjPalletPreShippingPL.fksalesorder);
            }
        }

        public frmPalletPreShippingPL(List<clsAymasDepot> pltList)
        {
            clsSalesOrder objSaleorder = new clsSalesOrder();
            InitializeComponent();
            dtpProgrammedDatePL.Value = dtpProgrammedDatePL.Value.AddDays(1);
            lblNumber.Text = (clsPalletPreShippingPL.GetOrdinalNumber() + 1).ToString();
            for (int i = 0; i < pltList.Count; i++)
            {
                dgvPreShippingPL.Rows.Add();
                dgvPreShippingPL.Rows[i].Cells[clmcodsec.Index].Value = pltList[i].codsec;
                dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[clmcodeshipping.Index].Value = pltList[i].palletCode;
                dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[clmproductshipping.Index].Value = pltList[i].film;
                clsSalesOrderDetail objSod = new clsSalesOrderDetail(pltList[i].fkSaleOrderDetail);
                objSaleorder = new clsSalesOrder(objSod.fkSalesOrder);
                dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[clmsalesordershipping.Index].Value = objSaleorder.number;
                dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[clmFKSalesOrderDetail.Index].Value = pltList[i].fkSaleOrderDetail;
                dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[clmnetweigthshipping.Index].Value = pltList[i].weigth;
                if (Convert.ToDouble(dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[clmnetweigthshipping.Index].Value) > 999.99)
                {
                    dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[clmnetweigthshipping.Index].Value = pltList[i].weigth.ToString("0,000.00");
                    
                }
                else
                {
                    dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[clmnetweigthshipping.Index].Value = pltList[i].weigth.ToString("00.00");
                    
                }
                totalweigth += pltList[i].weigth; 
                dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[imgdeleteshipping.Index].Value = global::BPS.Properties.Resources.cross;
                dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[clmPositionShipping.Index].Value = pltList[i].state;
                dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[clmImgToPalletsList.Index].Value = global::BPS.Properties.Resources.arrow_left;
                FillDataSalesOrder(pltList[i].codsec);  
            }
            txtTotalPalletKGPL.Text = totalweigth.ToString(); 

        }

        private void FindDataSalesOrder(int codsec)
        {
            FillDataSalesOrder(0);
            for (int i = 0; i < cmbSalesOrderPL.Items.Count; i++)
            {
                if (((clsSalesOrder)cmbSalesOrderPL.Items[i]).codsec == codsec)
                    cmbSalesOrderPL.SelectedIndex = i;
            }
        }

        private void FillDataSalesOrder(int codsec)
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            lstSalesOrder = clsSalesOrder.getActiveListForPreShipping();
            cmbSalesOrderPL.Items.Clear();
            for (int i = 0; i < lstSalesOrder.Count; i++)
                cmbSalesOrderPL.Items.Add(lstSalesOrder[i]);
        }

           private void cmbSalesOrderPL_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbSalesOrderPL.SelectedItem != null)
                FillPallets(((clsSalesOrder)cmbSalesOrderPL.SelectedItem).number);
        }

        private void FillPallets(string number) // recibe el  numero de OV del item seleccionado en el cmbSaleOrderPL
        {
            List<clsAymasDepot> lstPalletPreShipping = new List<clsAymasDepot>();
            lstPalletPreShipping = clsAymasDepot.getPalletListBySalesOrderNumber(number);
            dgvPalletPL.Rows.Clear();
            bool inthelist;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPreShippingListPL;");
            if (lstPalletPreShipping.Count > 0)
            {
                for (int i = 0; i < lstPalletPreShipping.Count; i++)
                {
                    inthelist = false;

                    for (int k = 0; k < DS.Tables[0].Rows.Count; k++)
                    {
                        if (DS.Tables[0].Rows[k][0].ToString() == lstPalletPreShipping[i].palletCode.ToString())
                        {
                            inthelist = true;
                        }
                    }

                    for (int j = 0; j < dgvPreShippingPL.Rows.Count; j++)
                    {
                        if (dgvPreShippingPL.Rows[j].Cells[clmcodeshipping.Index].Value.ToString() == lstPalletPreShipping[i].palletCode.ToString())
                        {
                            inthelist = true;
                        }
                    }
                    if (!inthelist)
                    {
                        dgvPalletPL.Rows.Add();
                        dgvPalletPL.Rows[dgvPalletPL.Rows.Count - 1].Cells[clmcode.Index].Value = lstPalletPreShipping[i].palletCode;
                        dgvPalletPL.Rows[dgvPalletPL.Rows.Count - 1].Cells[clmproduct.Index].Value = lstPalletPreShipping[i].film;
                        dgvPalletPL.Rows[dgvPalletPL.Rows.Count - 1].Cells[clmnumbersalesorder.Index].Value = lstPalletPreShipping[i].saleOrder;
                        dgvPalletPL.Rows[dgvPalletPL.Rows.Count - 1].Cells[clmnetweigth.Index].Value = Math.Round(lstPalletPreShipping[i].weigth, 2);
                        dgvPalletPL.Rows[dgvPalletPL.Rows.Count - 1].Cells[clmPosition.Index].Value = lstPalletPreShipping[i].state;
                        dgvPalletPL.Rows[dgvPalletPL.Rows.Count - 1].Cells[clmImgToShipp.Index].Value = global::BPS.Properties.Resources.arrow_right;

                    }
                }
            }
            else
            {
                dgvPalletPL.Rows.Clear();
                MessageBox.Show("No existen pallets asociados a esa orden", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateRow(string code)
        {
            bool flgValidate = true;
            for (int i = 0; i < dgvPreShippingPL.Rows.Count; i++)
            {
                if (dgvPreShippingPL.Rows[i].Cells[clmcodeshipping.Index].Value.ToString() == code)
                {
                    flgValidate = false;
                    break;
                }
            }
            return flgValidate;
        }

        private void btnAddPL_Click(object sender, EventArgs e)
        {
            if (codsec == 0)
            {
                if (dgvPreShippingPL.Rows.Count > 0)
                {
                    clsPalletPreShippingPL ObjPalletPreshipping = new clsPalletPreShippingPL();
                    for (int i = 0; i < dgvPreShippingPL.Rows.Count; i++)
                    {
                        ObjPalletPreshipping.fksalesorderdetail = Convert.ToInt32(dgvPreShippingPL.Rows[i].Cells[clmFKSalesOrderDetail.Index].Value);
                        ObjPalletPreshipping.palletcode = dgvPreShippingPL.Rows[i].Cells[clmcodeshipping.Index].Value.ToString();
                        ObjPalletPreshipping.number = Convert.ToInt32(lblNumber.Text);
                        ObjPalletPreshipping.date = DateTime.Now;
                        ObjPalletPreshipping.modifieddate = DateTime.Now;
                        ObjPalletPreshipping.programmeddate = dtpProgrammedDatePL.Value;
                        
                        if (!ObjPalletPreshipping.save())
                        {
                            flgValidate = false;
                            break;
                        }
                    }
                    if (flgValidate)
                    {
                        MessageBox.Show("Pre - Despacho # " + lblNumber.Text + " procesado correctamente..!", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clsGlobal.ClearForm(this);
                        this.Close();
                        frmPalletListPreShippingPL winPallet = new frmPalletListPreShippingPL();
                        winPallet.StartPosition = FormStartPosition.CenterScreen;
                        winPallet.Show();
                    }
                    else
                        MessageBox.Show("La información no ha podido ser guardada correctamente..!", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("No existen datos para guardar", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            }
        }

        private void dgvPalletPL_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmImgToShipp.Index)
            {
                dgvPreShippingPL.Rows.Add();
                dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[clmcodeshipping.Index].Value = dgvPalletPL.Rows[e.RowIndex].Cells[clmcode.Index].Value;
                dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[clmproductshipping.Index].Value = dgvPalletPL.Rows[e.RowIndex].Cells[clmproduct.Index].Value;
                dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[clmsalesordershipping.Index].Value = dgvPalletPL.Rows[e.RowIndex].Cells[clmnumbersalesorder.Index].Value;
                dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[clmnetweigthshipping.Index].Value = dgvPalletPL.Rows[e.RowIndex].Cells[clmnetweigth.Index].Value;
                dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[clmPositionShipping.Index].Value = dgvPalletPL.Rows[e.RowIndex].Cells[clmPosition.Index].Value;
                dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[clmImgToPalletsList.Index].Value = global::BPS.Properties.Resources.arrow_left;
                dgvPreShippingPL.Rows[dgvPreShippingPL.Rows.Count - 1].Cells[imgdeleteshipping.Index].Value = global::BPS.Properties.Resources.cross;
                totalweigth += Convert.ToDouble(dgvPalletPL.Rows[e.RowIndex].Cells[clmnetweigth.Index].Value);
                dgvPalletPL.Rows.RemoveAt(e.RowIndex);
            }
            txtTotalPalletKGPL.Text = totalweigth.ToString();
        }

        private void dgvPreShippingPL_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmImgToPalletsList.Index)
            {
                dgvPalletPL.Rows.Add();
                dgvPalletPL.Rows[dgvPalletPL.Rows.Count - 1].Cells[clmcode.Index].Value = dgvPreShippingPL.Rows[e.RowIndex].Cells[clmcodeshipping.Index].Value;
                dgvPalletPL.Rows[dgvPalletPL.Rows.Count - 1].Cells[clmproduct.Index].Value = dgvPreShippingPL.Rows[e.RowIndex].Cells[clmproductshipping.Index].Value;
                dgvPalletPL.Rows[dgvPalletPL.Rows.Count - 1].Cells[clmnumbersalesorder.Index].Value = dgvPreShippingPL.Rows[e.RowIndex].Cells[clmsalesordershipping.Index].Value;
                dgvPalletPL.Rows[dgvPalletPL.Rows.Count - 1].Cells[clmnetweigth.Index].Value = dgvPreShippingPL.Rows[e.RowIndex].Cells[clmnetweigthshipping.Index].Value;
                dgvPalletPL.Rows[dgvPalletPL.Rows.Count - 1].Cells[clmPosition.Index].Value = dgvPreShippingPL.Rows[e.RowIndex].Cells[clmPositionShipping.Index].Value;
                dgvPalletPL.Rows[dgvPalletPL.Rows.Count - 1].Cells[clmImgToShipp.Index].Value = global::BPS.Properties.Resources.arrow_right;
                totalweigth -=Convert.ToDouble(dgvPreShippingPL.Rows[e.RowIndex].Cells[clmnetweigthshipping.Index].Value);
                }
                txtTotalPalletKGPL.Text = totalweigth.ToString(); 
                dgvPreShippingPL.Rows.RemoveAt(e.RowIndex);
                
            if (cmbSalesOrderPL.SelectedItem != null)
                    FillPallets(((clsSalesOrder)cmbSalesOrderPL.SelectedItem).number);
            }
        
        private void btnExitPL_Click(object sender, EventArgs e)
        {
            if (dgvPreShippingPL.Rows.Count > 0)
            {
                if (MessageBox.Show("Esta realmente seguro que desea salir ya que los pallets para Pre - Despacho no se guardarán", "Pre - Despacho", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    this.Close();
            }
            else
                this.Close();
        }

        private void dgvPreShippingPL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == imgdeleteshipping.Index)
                dgvPreShippingPL.Rows.RemoveAt(e.RowIndex);
        }


        
    }
    }

