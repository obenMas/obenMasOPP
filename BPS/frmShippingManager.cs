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
    public partial class frmShippingManager : Form
    {
        internal List<clsPalletPreShipping> lstPallet = new List<clsPalletPreShipping>();
        internal List<string> lstPalletList = new List<string>();

        public frmShippingManager()
        {
            InitializeComponent();
        }

        private void frmShippingManager_Load(object sender, EventArgs e)
        {
            txtPalletCode.Focus();
            txtPalletCode.Select();
        }

        private void txtPalletCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstPallet = clsPalletPreShipping.getPalletListBySalesOrderNumberForAllDelivery(txtPalletCode.Text);
                if(lstPallet.Count > 0)
                {

                    for (int i = 0; i < lstPallet.Count; i++)
                    {
                        dgvPalletList.Rows.Add();
                        dgvPalletList.Rows[i].Cells[clmnumber.Index].Value = (dgvPalletList.Rows.Count == 1) ? 1 : dgvPalletList.Rows.Count;
                        dgvPalletList.Rows[i].Cells[clmCode.Index].Value = lstPallet[i].code;
                        dgvPalletList.Rows[i].Cells[clmStatus.Index].Value = "Por despachar";
                        dgvPalletList.Rows[i].Cells[clmimage.Index].Value = global::BPS.Properties.Resources.cross;
                    }
                //if (clsPallet.getPalletValidate(txtPalletCode.Text))
                //{
                //    if (dgvPalletList.Rows.Count == 0)
                //    {
                //        dgvPalletList.Rows.Add();
                //        dgvPalletList.Rows[0].Cells[clmnumber.Index].Value = (dgvPalletList.Rows.Count == 1) ? 1 : dgvPalletList.Rows.Count;
                //        dgvPalletList.Rows[0].Cells[clmCode.Index].Value = txtPalletCode.Text;
                //        dgvPalletList.Rows[0].Cells[clmStatus.Index].Value = "Por despachar";
                //        dgvPalletList.Rows[0].Cells[clmimage.Index].Value = global::BPS.Properties.Resources.cross;
                //        txtPalletCode.Text = string.Empty;
                //        txtPalletCode.Focus();
                //    }
                //    else
                //    {
                //        dgvPalletList.Rows.Add();
                //        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[clmnumber.Index].Value = (dgvPalletList.Rows.Count == 1) ? 1 : dgvPalletList.Rows.Count;
                //        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[clmCode.Index].Value = txtPalletCode.Text;
                //        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[clmStatus.Index].Value = "Por despachar";
                //        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[clmimage.Index].Value = global::BPS.Properties.Resources.cross;
                //        txtPalletCode.Text = string.Empty;
                //        txtPalletCode.Focus();
                //    }
                }
                else
                {
                    MessageBox.Show("Orden Ingresada no esta correcta", "Despachos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPalletCode.Text = string.Empty;
                    txtPalletCode.Focus();
                    txtPalletCode.Select();
                }
            }
        }

        private void dgvPalletList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmimage.Index)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar el pallet seleccionado?..", "Despachos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    dgvPalletList.Rows.RemoveAt(e.RowIndex);
                    ReCountRows();
                }
            }
        }

        private void ReCountRows()
        {
            for (int i = 0; i < dgvPalletList.Rows.Count; i++)
                dgvPalletList.Rows[i].Cells[clmnumber.Index].Value = (i + 1);
            
            txtPalletCode.Focus();
            txtPalletCode.Select();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que se desea despachar los pallets ingresados?...", "Despacho", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                List<string> lstPalletString = new List<string>();
                for (int i = 0; i < dgvPalletList.Rows.Count; i++)
                {
                    if (i != 0)
                    {
                        if (dgvPalletList.Rows[i - 1].Cells[clmCode.Index].Value.ToString() != dgvPalletList.Rows[i].Cells[clmCode.Index].Value.ToString())
                            lstPalletString.Add(dgvPalletList.Rows[i].Cells[clmCode.Index].Value.ToString());
                    }
                    else
                        lstPalletString.Add(dgvPalletList.Rows[i].Cells[clmCode.Index].Value.ToString());
                }

                try
                {
                    clsPallet.setPalletAsDeliveredNational(lstPalletString);
                    MessageBox.Show("Despachos realizados correctamente", "Despachos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenerateSummary(lstPalletString);
                    tbcShippingPalletFull.SelectTab(1);
                }
                catch { MessageBox.Show("Ha sucedido un error y la información no se generado correctamente", "Despachos", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void GenerateSummary(List<string> lstPalletString)
        {
            List<clsPallet> lstpalletshipping = new List<clsPallet>();
            lstpalletshipping = clsPallet.getCompleteListForShipping(lstPalletString);
            for (int i = 0; i < lstpalletshipping.Count; i++)
            {
                dgvPalletShipping.Rows.Add();
                dgvPalletShipping.Rows[i].Cells[clmnumberpallet.Index].Value = (dgvPalletShipping.Rows.Count == 1) ? 1 : dgvPalletShipping.Rows.Count;
                dgvPalletShipping.Rows[i].Cells[clmproductpallet.Index].Value = lstpalletshipping[i].product.code;
                dgvPalletShipping.Rows[i].Cells[clmcodepallet.Index].Value = lstpalletshipping[i].code;
                dgvPalletShipping.Rows[i].Cells[clmcustomerpallet.Index].Value = lstpalletshipping[i].customerName;
                dgvPalletShipping.Rows[i].Cells[clmorderpallet.Index].Value = lstpalletshipping[i].salesOrderNumber;
                dgvPalletShipping.Rows[i].Cells[clmnetweigthpallet.Index].Value = Math.Round(Convert.ToDouble(lstpalletshipping[i].netWeight), 2).ToString();
                dgvPalletShipping.Rows[i].Cells[clmgrossweigthpallet.Index].Value = lstpalletshipping[i].grossWeight;
                dgvPalletShipping.Rows[i].Cells[clmstatuspallet.Index].Value = lstpalletshipping[i].statusName;
                dgvPalletShipping.Rows[i].Cells[clmstatusdrawingpallet.Index].Value = (lstpalletshipping[i].statusName == "Despachado") ? global::BPS.Properties.Resources.delivery : global::BPS.Properties.Resources.cross;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea iniciar un nuevo despacho?..", "Despacho", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dgvPalletList.Rows.Clear();
                dgvPalletShipping.Rows.Clear();
                txtPalletCode.Focus();
                txtPalletCode.Select();
                tbcShippingPalletFull.SelectTab(0);
            }
        }
    }
}
