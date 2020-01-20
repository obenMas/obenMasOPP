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
    public partial class frmChangePalletType : Form
    {
        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        List<clsPalletTypeBySalesOrderDetail> lstPalletList = new List<clsPalletTypeBySalesOrderDetail>();
        List<clsPalletTypeBySalesOrderDetail> lstPalletTypeBySalesOrderDetail = new List<clsPalletTypeBySalesOrderDetail>();
        clsPallet objSelectedPallet = new clsPallet();
        clsPalletType objOriginalPalletType = new clsPalletType();
        clsPalletType objNewPalletType = new clsPalletType();

        public frmChangePalletType()
        {
            InitializeComponent();
        }

        public frmChangePalletType(int salesOrderDetailCodsec, int objPalletCodsec)
        {
            InitializeComponent();
            objSalesOrderDetail.load(salesOrderDetailCodsec);
            objSalesOrder.load(objSalesOrderDetail.fkSalesOrder);
            lstPalletTypeBySalesOrderDetail = clsPalletTypeBySalesOrderDetail.getListBySalesOrderDetail(salesOrderDetailCodsec);
            objSelectedPallet.load(objPalletCodsec);
            objOriginalPalletType.load(objSelectedPallet.fkPalletType);
        }

        private void frmAddNewStockPallet_Load(object sender, EventArgs e)
        {
            lblNumber.Text = objSalesOrder.number.ToString();
            lblProductName.Text = "[" + objSalesOrderDetail.product.code + "] " + objSalesOrderDetail.product.name;
            List<clsPalletType> lstPalletType = clsPalletType.getList();
            List<clsPalletDimentions> lstPalletDimention = clsPalletDimentions.getList();

            if (objSalesOrderDetail.codsec != 0)
            {
                for (int i = 0; i < lstPalletType.Count; i++)
                {
                    for (int j = 0; j < lstPalletTypeBySalesOrderDetail.Count; j++)
                    {
                        if (lstPalletTypeBySalesOrderDetail[j].fkPalletType == lstPalletType[i].codsec)
                            cmbPalletType.Items.Add(lstPalletType[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < lstPalletType.Count; i++)
                    cmbPalletType.Items.Add(lstPalletType[i]);
            }

            lstPalletList = clsPalletTypeBySalesOrderDetail.getListBySalesOrderDetail(objSalesOrderDetail.codsec);

            for (int i = 0; i < objSelectedPallet.lstCoil.Count; i++)
            {
                dgvCoils.Rows.Add();
                dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value = objSelectedPallet.lstCoil[i].codsec;
                dgvCoils.Rows[i].Cells[clmCoilCode.Index].Value = objSelectedPallet.lstCoil[i].code;
                dgvCoils.Rows[i].Cells[clmCoilLength.Index].Value = objSelectedPallet.lstCoil[i].length;
                dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objSelectedPallet.lstCoil[i].netWeight, 2));
                dgvCoils.Rows[i].Cells[clmCoilWidth.Index].Value = objSelectedPallet.lstCoil[i].width;
                dgvCoils.Rows[i].Cells[clmCoilAction.Index].Value = global::BPS.Properties.Resources.cross;
            }
            lblCoilCount.Text = "Bobinas : " + objSelectedPallet.lstCoil.Count.ToString() + " / " + objOriginalPalletType.coilNumber.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPalletType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsPalletType> lstPalletType = clsPalletType.getList();
                cmbPalletType.Items.Clear();
                for (int i = 0; i < lstPalletType.Count; i++)
                    cmbPalletType.Items.Add(lstPalletType[i]);
            }
        }

        private void cmbPalletType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((clsPalletType)cmbPalletType.SelectedItem).coilNumber < dgvCoils.Rows.Count)
            {
                MessageBox.Show("El número de bobinas del tipo de pallet seleccionado es menor al numero actual de bobinas del pallet. Para realizar el cambio es necesario que retire del pallet las bobinas sobrantes.", "Cambio de tipo de pallet", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                lblCoilCount.Text = "Bobinas : " + objSelectedPallet.lstCoil.Count.ToString() + " / " + ((clsPalletType)cmbPalletType.SelectedItem).coilNumber.ToString();
            }
            else if (((clsPalletType)cmbPalletType.SelectedItem).coilNumber > dgvCoils.Rows.Count)
            {
                MessageBox.Show("El número de bobinas del tipo de pallet seleccionado es mayor al numero actual de bobinas del pallet. Se realizará el cambio pero tenga en cuenta de completar las bobinas faltantes.", "Cambio de tipo de pallet", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                lblCoilCount.Text = "Bobinas : " + objSelectedPallet.lstCoil.Count.ToString() + " / " + ((clsPalletType)cmbPalletType.SelectedItem).coilNumber.ToString();
            }
        }

        private void btnChangePalletType_Click(object sender, EventArgs e)
        {
            if (((clsPalletType)cmbPalletType.SelectedItem) == null && dgvCoils.Rows.Count == 0)
            {
                objSelectedPallet.fkStatus = 42;
                objSelectedPallet.save();
            }
            else
            {
                if (((clsPalletType)cmbPalletType.SelectedItem) == null && dgvCoils.Rows.Count > 0)
                {
                    MessageBox.Show("Por favor debe ingresar el tipo de pallet a crear.", "Cambio de tipo de pallet", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    objSelectedPallet.fkStatus = 42;
                    objSelectedPallet.save();
                }
                else
                {
                    if (((clsPalletType)cmbPalletType.SelectedItem).coilNumber < dgvCoils.Rows.Count)
                        MessageBox.Show("El número de bobinas del tipo de pallet seleccionado es menor al numero actual de bobinas del pallet. Para realizar el cambio es necesario que retire del pallet las bobinas sobrantes.", "Cambio de tipo de pallet", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    else
                    {
                        objSelectedPallet.fkPalletType = ((clsPalletType)cmbPalletType.SelectedItem).codsec;
                        objSelectedPallet.fkStatus = 42;
                        objSelectedPallet.save();
                    }
                }
            }
        }

        private void dgvCoils_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCoilAction.Index)
            {
                if (MessageBox.Show("Esta seguro que desea eliminar la bobina del pallet?, este proceso es irreversible", "Registro de pallets", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    if (objSelectedPallet.removeCoilToPallet(Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value)))
                    {
                        dgvCoils.Rows.Remove(dgvCoils.Rows[e.RowIndex]);

                        if (((clsPalletType)cmbPalletType.SelectedItem) == null)
                            lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objOriginalPalletType.coilNumber.ToString();
                        else
                            lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + ((clsPalletType)cmbPalletType.SelectedItem).coilNumber.ToString();

                        double netWeight = 0;
                        for (int i = 0; i < dgvCoils.Rows.Count; i++)
                        {
                            netWeight += Convert.ToDouble(dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value);
                        }

                        objSelectedPallet.netWeight = netWeight;
                        objSelectedPallet.save();
                    }
                }
            }
        }
    }
}
