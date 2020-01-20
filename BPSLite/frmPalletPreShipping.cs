using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS.Lite
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
            this.codsec = codsec;
            if (codsec <= 0)
            {
                lblnumber.Text = (clsPalletPreShipping.GetOrdinalNumber() + 1).ToString();
                lblNumberPreShippingInternational.Text = (clsPalletPreShipping.GetOrdinalNumber() + 1).ToString();
                FillDataSalesOrder(0);
            }
            else
            {
                clsPalletPreShipping ObjPalletPreShipping = new clsPalletPreShipping(codsec);
                lblnumber.Text = clsPalletPreShipping.GetOrdinalNumber().ToString();
                lblNumberPreShippingInternational.Text = clsPalletPreShipping.GetOrdinalNumber().ToString();
                txtOrderNumber.Text = ObjPalletPreShipping.number.ToString();
                FindDataSalesOrder(ObjPalletPreShipping.fksalesorder);
            }
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
            if (lstPalletPreShipping.Count > 0)
            {
                for (int i = 0; i < lstPalletPreShipping.Count; i++)
                {
                    if (lstPalletPreShipping[i].fkStatus != 40)
                    {
                        dgvPallet.Rows.Add();
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmcodsec.Index].Value = lstPalletPreShipping[i].fkpallet;
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmcode.Index].Value = lstPalletPreShipping[i].code;
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmproduct.Index].Value = lstPalletPreShipping[i].codeproduct;
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmnumbersalesorder.Index].Value = lstPalletPreShipping[i].salesordernumber;
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmnumberpallet.Index].Value = lstPalletPreShipping[i].palletnumber;
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmcoilnumber.Index].Value = lstPalletPreShipping[i].coilnumber;
                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmnetweigth.Index].Value = Math.Round(lstPalletPreShipping[i].netweight, 2); 
                    }
                }
            }
            else
            {
                dgvPallet.Rows.Clear();
                MessageBox.Show("No existen pallets asociados a esa orden", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtOrderNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int number = clsSalesOrder.getDetailByNumberSimple(Convert.ToInt32(txtOrderNumber.Text)); // modificado
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
        }

        private void dgvPallet_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.dgvPallet.DoDragDrop(this.dgvPallet.CurrentRow, DragDropEffects.All);
        }

        private void dgvPreShipping_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                if (ValidateRow(rowToMove.Cells[clmcode.Index].Value.ToString()))
                {
                    dgvPreShipping.Rows.Add();
                    dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmcodsecshipping.Index].Value = rowToMove.Cells[clmcodsec.Index].Value;
                    dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmcodeshipping.Index].Value = rowToMove.Cells[clmcode.Index].Value;
                    dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmproductshipping.Index].Value = rowToMove.Cells[clmproduct.Index].Value;
                    dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmsalesordershipping.Index].Value = rowToMove.Cells[clmsalesordershipping.Index].Value;
                    dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clsnetweigthshipping.Index].Value = rowToMove.Cells[clmnetweigth.Index].Value;
                    dgvPreShipping.Rows[dgvPreShipping.Rows.Count - 1].Cells[clmdeleteshipping.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                }
                else
                    MessageBox.Show("El pallet que desea mover ya pertenece a la lista de Pre - Despachos por favor selecione otro pallet", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

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

        private void dgvPreShipping_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
                e.Effect = DragDropEffects.Move;
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
                        ObjPalletPreshipping.fksalesorder = clsSalesOrder.getDetailByNumberSimple(Convert.ToInt32(dgvPreShipping.Rows[i].Cells[clmsalesordershipping.Index].Value)); // modificado
                        ObjPalletPreshipping.code = dgvPreShipping.Rows[i].Cells[clmcodeshipping.Index].Value.ToString();
                        ObjPalletPreshipping.number = Convert.ToInt32(lblnumber.Text);
                        ObjPalletPreshipping.date = DateTime.Now;
                        ObjPalletPreshipping.isinternational = false;
                        if (!ObjPalletPreshipping.save())
                        {
                            flgValidate = false;
                            break;
                        }
                    }
                    if (flgValidate)
                    {
                        MessageBox.Show("Pre - Despacho # " + lblnumber.Text + " procesado correctamente..!", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {

            }
        }

        private void txtInternationalSalesOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int number = clsSalesOrder.getDetailByNumberSimple(Convert.ToInt32(txtInternationalSalesOrder.Text)); // modificado a int32
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
                    dgvInternationalTo.Rows[dgvInternationalTo.Rows.Count - 1].Cells[clmdeleteshipping.Index].Value = global::BPS.Lite.Properties.Resources.cross;
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
    }
}
