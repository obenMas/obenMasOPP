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
    public partial class frmPalletPreShipping : Form
    {
        public string procedence = string.Empty;

        public int codsec = 0, totalcoil = 0;

        public double totalweigth = 0;

        public bool flgValidate = true;

        public frmPalletPreShipping()
        {
            InitializeComponent();
        }

        public frmPalletPreShipping(int codsec)
        {
            InitializeComponent();
            dtpProgrammedDate.Value = DateTime.Today.AddDays(1); //cambia el dateTimePicker al dia siguiente del actual.
            this.codsec = codsec;
            if (codsec <= 0)
            {
                lblnumber.Text = (clsPalletPreShipping.GetOrdinalNumber() + 1).ToString();
                //lblNumberPreShippingInternational.Text = (clsPalletPreShipping.GetOrdinalNumber() + 1).ToString();
                FillDataSalesOrder(0);
            }
            else
            {
                clsPalletPreShipping ObjPalletPreShipping = new clsPalletPreShipping(codsec);
                lblnumber.Text = clsPalletPreShipping.GetOrdinalNumber().ToString();
                //lblNumberPreShippingInternational.Text = clsPalletPreShipping.GetOrdinalNumber().ToString();
                //txtOrderNumber.Text = ObjPalletPreShipping.number;
                FindDataSalesOrder(ObjPalletPreShipping.fksalesorder);
            }
        }

        public frmPalletPreShipping(List<clsPallet> pltList)
        {
            clsSalesOrderDetail objSaleorderd = new clsSalesOrderDetail();
            InitializeComponent();
            dtpProgrammedDate.Value = DateTime.Today.AddDays(1);
            lblnumber.Text = (clsPalletPreShipping.GetOrdinalNumber() + 1).ToString();
            for (int i = 0; i < pltList.Count; i++)
            {
                dgvPreShipping.Rows.Add();
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmcodsecshipping.Index].Value = pltList[i].codsec;
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmcodeshipping.Index].Value = pltList[i].code;
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmproductshipping.Index].Value = pltList[i].product.code;
                objSaleorderd = new clsSalesOrderDetail(pltList[i].fkSalesOrderDetail);
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmsalesordershipping.Index].Value = objSaleorderd.codsec;
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clsnetweigthshipping.Index].Value = pltList[i].netWeight;
                if (Convert.ToDouble(dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clsnetweigthshipping.Index].Value) > 999.99)
                {
                    dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clsnetweigthshipping.Index].Value = pltList[i].netWeight.ToString("0,000.00");
                    
                }
                else
                {
                    dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clsnetweigthshipping.Index].Value = pltList[i].netWeight.ToString("00.00");
                    
                }
                totalweigth += Math.Round(pltList[i].netWeight, 2); 
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmdeleteshipping.Index].Value = global::BPS.Properties.Resources.cross;
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmGrossWeightShipping.Index].Value = pltList[i].grossWeight;
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmPositionShipping.Index].Value = pltList[i].position;
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmImgToPalletsList.Index].Value = global::BPS.Properties.Resources.arrow_left;
                FillDataSalesOrder(pltList[i].codsec);
            }
            txtTotalPalletKG.Text = Math.Round(totalweigth, 2).ToString();
        }

        private void FindDataSalesOrder(int codsec)
        {
            FillDataSalesOrder(0);
            for (int i = 0; i < cmbSalesOrder.Items.Count; i++)
            {
                if (((clsSalesOrder)cmbSalesOrder.Items[i]).codsec == codsec)
                    cmbSalesOrder.SelectedIndex = i;
            }
        }

        private void FillDataSalesOrder(int codsec)
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            lstSalesOrder = clsSalesOrder.getActiveListForPreShipping();
            cmbSalesOrder.Items.Clear();
            for (int i = 0; i < lstSalesOrder.Count; i++)
                cmbSalesOrder.Items.Add(lstSalesOrder[i]);
        }

        private void cmbSalesOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSalesOrder.SelectedItem != null)
                FillPallets(((clsSalesOrder)cmbSalesOrder.SelectedItem).number);
        }

        private void FillPallets(string number)
        {
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            lstPalletPreShipping = clsPalletPreShipping.getPalletListBySalesOrderNumberOnlyPT(number);
            dgvPallet.Rows.Clear();
            bool inthelist;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPreShippingList;");
            if (lstPalletPreShipping.Count > 0)
            {
                for (int i = 0; i < lstPalletPreShipping.Count; i++)
                {
                    inthelist = false;

                    for (int k = 0; k < DS.Tables[0].Rows.Count; k++)
                    {
                        if (DS.Tables[0].Rows[k][0].ToString() == lstPalletPreShipping[i].code.ToString())
                        {
                            inthelist = true;
                        }
                    }

                    for (int j = 0; j < dgvPreShipping.Rows.Count; j++)
                    {
                        if (dgvPreShipping.Rows[j].Cells[clmcodeshipping.Index].Value.ToString() == lstPalletPreShipping[i].code.ToString())
                        {
                            inthelist = true;
                        }
                    }
                    if (lstPalletPreShipping[i].fkStatus != 40 && !inthelist)
                    {
                        dgvPallet.Rows.Add();
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmcodsec.Index].Value = lstPalletPreShipping[i].fkpallet;
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmcode.Index].Value = lstPalletPreShipping[i].code;
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmproduct.Index].Value = lstPalletPreShipping[i].codeproduct;
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmnumbersalesorder.Index].Value = lstPalletPreShipping[i].salesordernumber;
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmnumberpallet.Index].Value = lstPalletPreShipping[i].palletnumber;
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmcoilnumber.Index].Value = lstPalletPreShipping[i].coilnumber;
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmnetweigth.Index].Value = Math.Round(lstPalletPreShipping[i].netweight, 2);
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmGrossWeight.Index].Value = Math.Round(new clsPallet(lstPalletPreShipping[i].fkpallet).grossWeight, 2);
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmPosition.Index].Value = new clsPallet(lstPalletPreShipping[i].fkpallet).position;

                    }
                }
            }
            else
            {
                dgvPallet.Rows.Clear();
                MessageBox.Show("No existen pallets asociados a esa orden", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*  private void txtOrderNumber_KeyDown(object sender, KeyEventArgs e)
          {
              if (e.KeyCode == Keys.Enter)
              {
                  int number = clsSalesOrder.getDetailByNumberSimple(txtOrderNumber.Text);
                  cmbSalesOrder.SelectedIndex = -1;

                  if (number > 0)
                      FillPallets(txtOrderNumber.Text);
                  else
                  {
                      MessageBox.Show("No existe el número de orden ingresado", "Pre -  Despachos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      txtOrderNumber.Clear();
                      cmbSalesOrder.SelectedIndex = -1;
                  }
              }
          }*/

        private bool ValidateRow(string code)
        {
            bool flgValidate = true;
            for (int i = 0; i < dgvPreShipping.Rows.Count; i++)
            {
                if (dgvPreShipping.Rows[i].Cells[clmcodeshipping.Index].Value.ToString() == code)
                {
                    flgValidate = false;
                    break;
                }
            }
            return flgValidate;
        }

        private void dgvPreShipping_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmdeleteshipping.Index)
                dgvPreShipping.Rows.RemoveAt(e.RowIndex);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (dgvPreShipping.Rows.Count > 0)
            {
                if (MessageBox.Show("Esta realmente seguro que desea salir ya que los pallets para Pre - Despacho no se guardarán", "Pre - Despacho", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    this.Close();
            }
            else
                this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (codsec == 0)
            {
                if (dgvPreShipping.Rows.Count > 0)
                {
                    clsPalletPreShipping ObjPalletPreshipping = new clsPalletPreShipping();
                    for (int i = 0; i < dgvPreShipping.Rows.Count; i++)
                    {
                        ObjPalletPreshipping.fkpallet = Convert.ToInt32(dgvPreShipping.Rows[i].Cells[clmcodsecshipping.Index].Value.ToString());
                        ObjPalletPreshipping.fksalesorder = clsSalesOrder.getDetailByNumberSimple(Convert.ToInt32(dgvPreShipping.Rows[i].Cells[clmsalesordershipping.Index].Value));
                        ObjPalletPreshipping.code = dgvPreShipping.Rows[i].Cells[clmcodeshipping.Index].Value.ToString();
                        ObjPalletPreshipping.number = Convert.ToInt32(lblnumber.Text);
                        ObjPalletPreshipping.date = DateTime.Now;
                        ObjPalletPreshipping.isinternational = false;
                        ObjPalletPreshipping.programmeddate = Convert.ToDateTime(dtpProgrammedDate.Value);
                        ObjPalletPreshipping.nodate = Convert.ToBoolean(chkNodate.Checked);
                        if (!ObjPalletPreshipping.save())
                        {
                            flgValidate = false;
                            break;
                        }
                    }
                    if (flgValidate)
                    {
                        MessageBox.Show("Pre - Despacho # " + lblnumber.Text + " procesado correctamente.", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clsGlobal.ClearForm(this);
                        this.Close();
                        frmPalletListPreShipping winPallet = new frmPalletListPreShipping();
                        winPallet.StartPosition = FormStartPosition.CenterScreen;
                        winPallet.Show();
                    }
                    else
                        MessageBox.Show("La información no ha podido ser guardada correctamente.", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("No existen datos para guardar", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            }
        }

        private void txtInternationalSalesOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int number = clsSalesOrder.getDetailByNumberSimple(Convert.ToInt32(txtInternationalSalesOrder.Text));
                if (number > 0)
                    FillInternationalPallets(txtInternationalSalesOrder.Text);
                else
                {
                    MessageBox.Show("No existe el número de orden ingresado", "Pre -  Despachos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtInternationalSalesOrder.Clear();
                }
            }
        }

        private void FillInternationalPallets(string internationalsalesnumber)
        {
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            lstPalletPreShipping = clsPalletPreShipping.getInternationalPalletListBySalesOrderNumber(internationalsalesnumber);
            dgvInternationalFrom.Rows.Clear();
            if (lstPalletPreShipping.Count > 0)
            {
                totalcoil = 0;
                totalweigth = 0;
                for (int i = 0; i < lstPalletPreShipping.Count; i++)
                {
                    dgvInternationalFrom.Rows.Add();
                    dgvInternationalFrom.Rows[i].Cells[clminternationalcustomerfrom.Index].Value = lstPalletPreShipping[i].companyname;
                    dgvInternationalFrom.Rows[i].Cells[clminternationalcodsec.Index].Value = lstPalletPreShipping[i].fkpallet;
                    dgvInternationalFrom.Rows[i].Cells[clminternationalcode.Index].Value = lstPalletPreShipping[i].code;
                    dgvInternationalFrom.Rows[i].Cells[clminternationalproduct.Index].Value = lstPalletPreShipping[i].codeproduct;
                    dgvInternationalFrom.Rows[i].Cells[clminternationalorder.Index].Value = lstPalletPreShipping[i].salesordernumber;
                    dgvInternationalFrom.Rows[i].Cells[clminternationalnumberpallet.Index].Value = lstPalletPreShipping[i].palletnumber;
                    dgvInternationalFrom.Rows[i].Cells[clminternationalnumbercoil.Index].Value = lstPalletPreShipping[i].coilnumber;
                    dgvInternationalFrom.Rows[i].Cells[clminternationalnetweitgh.Index].Value = Math.Round(lstPalletPreShipping[i].netweight, 2);
                    totalcoil += lstPalletPreShipping[i].coilnumber;
                    totalweigth += Math.Round(lstPalletPreShipping[i].netweight, 2);
                }
                lblTotalPallet.Text = dgvInternationalFrom.Rows.Count.ToString();
                lblTotalCoil.Text = totalcoil.ToString();
                lblTotalWeigth.Text = totalweigth.ToString();
            }
            else
            {
                dgvPallet.Rows.Clear();
                MessageBox.Show("No existen pallets asociados a esa orden", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (dgvInternationalFrom.Rows.Count > 0)
            {
                if (ValidateInternationalRow(txtInternationalSalesOrder.Text))
                {
                    dgvInternationalTo.Rows.Add();
                    dgvInternationalTo.Rows[dgvInternationalTo.Rows.Count - 1].Cells[clminternationorderto.Index].Value = txtInternationalSalesOrder.Text;
                    dgvInternationalTo.Rows[dgvInternationalTo.Rows.Count - 1].Cells[clminternationalcustomer.Index].Value = dgvInternationalFrom.Rows[0].Cells[clminternationalcustomerfrom.Index].Value.ToString();
                    dgvInternationalTo.Rows[dgvInternationalTo.Rows.Count - 1].Cells[clminternationaltotalpallet.Index].Value = lblTotalPallet.Text;
                    dgvInternationalTo.Rows[dgvInternationalTo.Rows.Count - 1].Cells[clminternationaltotalcoil.Index].Value = lblTotalCoil.Text;
                    dgvInternationalTo.Rows[dgvInternationalTo.Rows.Count - 1].Cells[clminternationaltotalnetweigth.Index].Value = lblTotalWeigth.Text;
                    dgvInternationalTo.Rows[dgvInternationalTo.Rows.Count - 1].Cells[clmdeleteshipping.Index].Value = global::BPS.Properties.Resources.cross;
                }
                else
                    MessageBox.Show("La orden que está intentando ingresar ya fue ingresada por favor vuelva a selecionar otra orden", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("No exiten pallet para generar el pre - despacho", "Pre -  Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvInternationalFrom.Rows.Clear();
                txtInternationalSalesOrder.Clear();
                txtInternationalSalesOrder.Focus();
            }
        }

        private bool ValidateInternationalRow(string order)
        {
            bool flgValidate = true;
            for (int i = 0; i < dgvInternationalTo.Rows.Count; i++)
            {
                if (dgvInternationalTo.Rows[i].Cells[clminternationorderto.Index].Value.ToString() == order)
                {
                    flgValidate = false;
                    break;
                }
            }
            return flgValidate;
        }

        private void dgvInternationalTo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clminternationaltodelete.Index)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar la orden selecionada", "Pre - Despacho", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    dgvInternationalTo.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnExecuteInternationalTransferFull_Click(object sender, EventArgs e)
        {
            if (dgvInternationalTo.Rows.Count > 0)
            {
                List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
                clsPalletPreShipping ObjPalletPreshipping = new clsPalletPreShipping();
                for (int i = 0; i < dgvInternationalTo.Rows.Count; i++)
                {
                    lstPalletPreShipping = clsPalletPreShipping.getInternationalPalletListBySalesOrderNumber(dgvInternationalTo.Rows[i].Cells[clminternationorderto.Index].Value.ToString());
                    for (int j = 0; j < lstPalletPreShipping.Count; j++)
                    {
                        ObjPalletPreshipping.fkpallet = lstPalletPreShipping[j].fkpallet;
                        ObjPalletPreshipping.fksalesorder = lstPalletPreShipping[j].fksalesorder;
                        ObjPalletPreshipping.code = lstPalletPreShipping[j].code;
                        ObjPalletPreshipping.number = Convert.ToInt32(lblNumberPreShippingInternational.Text);
                        ObjPalletPreshipping.date = DateTime.Now;
                        ObjPalletPreshipping.isinternational = true;
                        if (!ObjPalletPreshipping.save())
                        {
                            flgValidate = false;
                            break;
                        }
                    }
                    lstPalletPreShipping = new List<clsPalletPreShipping>();
                }
                if (flgValidate)
                {
                    MessageBox.Show("Pre - Despacho # " + lblNumberPreShippingInternational.Text + " procesado correctamente..!", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clsGlobal.ClearForm(this);
                    this.Close();
                    frmPalletListPreShipping winPallet = new frmPalletListPreShipping();
                    winPallet.StartPosition = FormStartPosition.CenterScreen;
                    winPallet.Show();
                }
                else
                    MessageBox.Show("La información no ha podido ser guardada correctamente..!", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No existen datos para guardar", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvPallet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.ColumnIndex == clmImgToShipp.Index)
            {
                dgvPreShipping.Rows.Add();
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmcodsecshipping.Index].Value = dgvPallet.Rows[e.RowIndex].Cells[clmcodsec.Index].Value;
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmcodeshipping.Index].Value = dgvPallet.Rows[e.RowIndex].Cells[clmcode.Index].Value;
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmproductshipping.Index].Value = dgvPallet.Rows[e.RowIndex].Cells[clmproduct.Index].Value;
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmsalesordershipping.Index].Value = dgvPallet.Rows[e.RowIndex].Cells[clmnumbersalesorder.Index].Value;
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clsnetweigthshipping.Index].Value = dgvPallet.Rows[e.RowIndex].Cells[clmnetweigth.Index].Value;
                totalweigth += Math.Round(Convert.ToDouble(dgvPallet.Rows[e.RowIndex].Cells[clmnetweigth.Index].Value),2);
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmGrossWeightShipping.Index].Value = dgvPallet.Rows[e.RowIndex].Cells[clmGrossWeight.Index].Value;
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmPositionShipping.Index].Value = dgvPallet.Rows[e.RowIndex].Cells[clmPosition.Index].Value;
                dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmImgToPalletsList.Index].Value = global::BPS.Properties.Resources.arrow_left;
                dgvPallet.Rows.RemoveAt(e.RowIndex);
            }
            txtTotalPalletKG.Text = Math.Round(totalweigth,2).ToString();
        }

        private void dgvPreShipping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmImgToPalletsList.Index)
            {
                dgvPallet.Rows.Add();
                dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmcode.Index].Value = dgvPreShipping.Rows[e.RowIndex].Cells[clmcodeshipping.Index].Value;
                dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmproduct.Index].Value = dgvPreShipping.Rows[e.RowIndex].Cells[clmproductshipping.Index].Value;
                dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmnumbersalesorder.Index].Value = dgvPreShipping.Rows[e.RowIndex].Cells[clmsalesordershipping.Index].Value;
                dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmnetweigth.Index].Value = dgvPreShipping.Rows[e.RowIndex].Cells[clsnetweigthshipping.Index].Value;
                dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmPosition.Index].Value = dgvPreShipping.Rows[e.RowIndex].Cells[clmPositionShipping.Index].Value;
                dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmImgToShipp.Index].Value = global::BPS.Properties.Resources.arrow_right;
                dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmGrossWeight.Index].Value = dgvPreShipping.Rows[e.RowIndex].Cells[clmGrossWeightShipping.Index].Value;
                totalweigth -= Math.Round(Convert.ToDouble(dgvPreShipping.Rows[e.RowIndex].Cells[clsnetweigthshipping.Index].Value), 2);
                }
                txtTotalPalletKG.Text = totalweigth.ToString(); 
                
                dgvPreShipping.Rows.RemoveAt(e.RowIndex);

                if (cmbSalesOrder.SelectedItem != null)
                    FillPallets(((clsSalesOrder)cmbSalesOrder.SelectedItem).number);
            }
        }
    }

