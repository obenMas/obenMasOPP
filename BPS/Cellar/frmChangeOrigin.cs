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
    public partial class frmChangeOrigin : Form
    {
        public bool isAutoricet = false;

        public frmChangeOrigin()
        {
            frmCellarLogin winLogin = new frmCellarLogin(this);
            winLogin.ShowDialog(this);

            if (isAutoricet)
            {
                InitializeComponent();
                grpbTrans.Enabled = false;
            }
            else
                this.Close();
            
        }

        private void chkEnableTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnableTransfer.Checked == true)
            {
                grpbTrans.Enabled = true;
                dgvTransfer.Enabled = true;
            }
            else if (chkEnableTransfer.Checked == false)
            {
                dgvTransfer.Enabled = false;
                grpbTrans.Enabled = false;
            }
        }

        private void cmbCompanyTransfer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvTransfer_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect == DragDropEffects.Move)
            {
                DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                dgvTransfer.Rows.Add();
                dgvTransfer.Rows[dgvTransfer.Rows.Count - 1].Cells[clmcodeccellartransfer.Index].Value = (cmbCellar.Text.ToString() == "Bopp") ? 0 : 1;
                dgvTransfer.Rows[dgvTransfer.Rows.Count - 1].Cells[clmcodsecpallettransfer.Index].Value = rowToMove.Cells[clmcodsec.Index].Value;
                dgvTransfer.Rows[dgvTransfer.Rows.Count - 1].Cells[clmcodetransfer.Index].Value = rowToMove.Cells[clmcode.Index].Value;
                dgvTransfer.Rows[dgvTransfer.Rows.Count - 1].Cells[clmcustomertransfer.Index].Value = rowToMove.Cells[clmcustomer.Index].Value;
                dgvTransfer.Rows[dgvTransfer.Rows.Count - 1].Cells[clmnetweigthtransfer.Index].Value = rowToMove.Cells[clmnetweigth.Index].Value;
                dgvTransfer.Rows[dgvTransfer.Rows.Count - 1].Cells[clmorigintransfer.Index].Value = cmbCellar.Text.ToString();
                dgvTransfer.Rows[dgvTransfer.Rows.Count - 1].Cells[clmordertransfer.Index].Value = rowToMove.Cells[clmnumber.Index].Value;
                dgvTransfer.Rows[dgvTransfer.Rows.Count - 1].Cells[clmcellarnametransfer.Index].Value = rowToMove.Cells[clmcellarname.Index].Value;
                dgvTransfer.Rows[dgvTransfer.Rows.Count - 1].Cells[clmpalbobtransfer.Index].Value = rowToMove.Cells[clmpalbob.Index].Value;
                dgvTransfer.Rows[dgvTransfer.Rows.Count - 1].Cells[clmdelete.Index].Value = global::BPS.Properties.Resources.cross;
            }
        }

        private void dgvTransfer_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
                e.Effect = DragDropEffects.Move;
        }

        private void dgvTransfer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmdelete.Index)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar la transferencia del pallet seleccionado?", "Transferencia de Origen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true) == DialogResult.Yes)
                    dgvTransfer.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está realmente seguro de cancelar las transferencias por realizar", "Transferencia de Origen", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true) == DialogResult.OK)
                dgvTransfer.Rows.Clear();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea continuar con las transferencias habilitadas?", "Transferencia de Origen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
            {   
                for (int i = 0; i < dgvTransfer.Rows.Count; i++)
                {
                    clsPallet ObjPallet = new clsPallet();
                    ObjPallet.load(Convert.ToInt32(dgvTransfer.Rows[i].Cells[clmcodsecpallettransfer.Index].Value));
                    switch (dgvTransfer.Rows[i].Cells[clmcodeccellartransfer.Index].Value.ToString())
                    {
                        case "1":

                            for (int j = 0; j < ObjPallet.lstCoil.Count; j++)
                            {
                                clsCoil Objcoil = new clsCoil(ObjPallet.lstCoil[j].codsec);
                                Objcoil.isExternalCoil = true;
                                Objcoil.toupdate();
                            }

                            switch (dgvTransfer.Rows[i].Cells[clmcellarnametransfer.Index].Value.ToString())
                            {
                                case "Empaque":
                                    clsPallet.transferTo(DateTime.Now, ObjPallet.code, ObjPallet.codsec, 1, ObjPallet.product.code, ObjPallet.palletNumber, ObjPallet.customerName, ObjPallet.salesOrderNumber, Convert.ToInt32(ObjPallet.product.width), ObjPallet.netWeight, "Transferencia directa", true);
                                    break;
                                case "Proceso":
                                    clsPallet.transferTo(DateTime.Now, ObjPallet.code, ObjPallet.codsec, 2, ObjPallet.product.code, ObjPallet.palletNumber, ObjPallet.customerName, ObjPallet.salesOrderNumber, Convert.ToInt32(ObjPallet.product.width), ObjPallet.netWeight, "Salida a bodega de proceso", false);
                                    break;
                                case "Producto Terminado":
                                    clsPallet.transferTo(DateTime.Now, ObjPallet.code, ObjPallet.codsec, 3, ObjPallet.product.code, ObjPallet.palletNumber, ObjPallet.customerName, ObjPallet.salesOrderNumber, Convert.ToInt32(ObjPallet.product.width), ObjPallet.netWeight, "Ingreso a bodega de producto terminado", true);
                                    break;
                                case "Stock Local":
                                    clsPallet.transferTo(DateTime.Now, ObjPallet.code, ObjPallet.codsec, 4, ObjPallet.product.code, ObjPallet.palletNumber, ObjPallet.customerName, ObjPallet.salesOrderNumber, Convert.ToInt32(ObjPallet.product.width), ObjPallet.netWeight, "Ingreso a bodega de stock local", true);
                                    break;
                                case "Metalizado":
                                    clsPallet.transferTo(DateTime.Now, ObjPallet.code, ObjPallet.codsec, 5, ObjPallet.product.code, ObjPallet.palletNumber, ObjPallet.customerName, ObjPallet.salesOrderNumber, Convert.ToInt32(ObjPallet.product.width), ObjPallet.netWeight, "Salida a bodega de base para metalizar", false);
                                    break;
                                case "Bajas":
                                    clsPallet.transferTo(DateTime.Now, ObjPallet.code, ObjPallet.codsec, 7, ObjPallet.product.code, ObjPallet.palletNumber, ObjPallet.customerName, ObjPallet.salesOrderNumber, Convert.ToInt32(ObjPallet.product.width), ObjPallet.netWeight, "Salida de bodega de bajas", false);
                                    break;
                                case "Stock Perú":
                                    clsPallet.transferTo(DateTime.Now, ObjPallet.code, ObjPallet.codsec, 8, ObjPallet.product.code, ObjPallet.palletNumber, ObjPallet.customerName, ObjPallet.salesOrderNumber, Convert.ToInt32(ObjPallet.product.width), ObjPallet.netWeight, "Ingreso a bodega de stock Perú", true);
                                    break;
                                case "Base para metalizar":
                                    clsPallet.transferTo(DateTime.Now, ObjPallet.code, ObjPallet.codsec, 9, ObjPallet.product.code, ObjPallet.palletNumber, ObjPallet.customerName, ObjPallet.salesOrderNumber, Convert.ToInt32(ObjPallet.product.width), ObjPallet.netWeight, "Salida a bodega de base para metalizar", false);
                                    break;
                                default:
                                    break;
                            }

                            break;
                        case "0":
                            for (int j = 0; j < ObjPallet.lstCoil.Count; j++)
                            {
                                clsCoil Objcoil = new clsCoil(ObjPallet.lstCoil[j].codsec);
                                Objcoil.isExternalCoil = false;
                                Objcoil.toupdate();
                            }

                            switch (dgvTransfer.Rows[i].Cells[clmcellarnametransfer.Index].Value.ToString())
                            {
                                case "Empaque":
                                    clsPallet.transferTo(DateTime.Now, ObjPallet.code, ObjPallet.codsec, 1, ObjPallet.product.code, ObjPallet.palletNumber, ObjPallet.customerName, ObjPallet.salesOrderNumber, Convert.ToInt32(ObjPallet.product.width), ObjPallet.netWeight, "Transferencia directa", true);
                                    break;
                                case "Proceso":
                                    clsPallet.transferTo(DateTime.Now, ObjPallet.code, ObjPallet.codsec, 2, ObjPallet.product.code, ObjPallet.palletNumber, ObjPallet.customerName, ObjPallet.salesOrderNumber, Convert.ToInt32(ObjPallet.product.width), ObjPallet.netWeight, "Salida a bodega de proceso", false);
                                    break;
                                case "Producto Terminado":
                                    clsPallet.transferTo(DateTime.Now, ObjPallet.code, ObjPallet.codsec, 3, ObjPallet.product.code, ObjPallet.palletNumber, ObjPallet.customerName, ObjPallet.salesOrderNumber, Convert.ToInt32(ObjPallet.product.width), ObjPallet.netWeight, "Ingreso a bodega de producto terminado", true);
                                    break;
                                case "Stock Local":
                                    clsPallet.transferTo(DateTime.Now, ObjPallet.code, ObjPallet.codsec, 4, ObjPallet.product.code, ObjPallet.palletNumber, ObjPallet.customerName, ObjPallet.salesOrderNumber, Convert.ToInt32(ObjPallet.product.width), ObjPallet.netWeight, "Ingreso a bodega de stock local", true);
                                    break;
                                case "Metalizado":
                                    clsPallet.transferTo(DateTime.Now, ObjPallet.code, ObjPallet.codsec, 5, ObjPallet.product.code, ObjPallet.palletNumber, ObjPallet.customerName, ObjPallet.salesOrderNumber, Convert.ToInt32(ObjPallet.product.width), ObjPallet.netWeight, "Salida a bodega de base para metalizar", false);
                                    break;
                                case "Bajas":
                                    clsPallet.transferTo(DateTime.Now, ObjPallet.code, ObjPallet.codsec, 7, ObjPallet.product.code, ObjPallet.palletNumber, ObjPallet.customerName, ObjPallet.salesOrderNumber, Convert.ToInt32(ObjPallet.product.width), ObjPallet.netWeight, "Salida de bodega de bajas", false);
                                    break;
                                case "Stock Perú":
                                    clsPallet.transferTo(DateTime.Now, ObjPallet.code, ObjPallet.codsec, 8, ObjPallet.product.code, ObjPallet.palletNumber, ObjPallet.customerName, ObjPallet.salesOrderNumber, Convert.ToInt32(ObjPallet.product.width), ObjPallet.netWeight, "Ingreso a bodega de stock Perú", true);
                                    break;
                                case "Base para metalizar":
                                    clsPallet.transferTo(DateTime.Now, ObjPallet.code, ObjPallet.codsec, 9, ObjPallet.product.code, ObjPallet.palletNumber, ObjPallet.customerName, ObjPallet.salesOrderNumber, Convert.ToInt32(ObjPallet.product.width), ObjPallet.netWeight, "Salida a bodega de base para metalizar", false);
                                    break;
                                default:
                                    break;
                            }

                            break;
                        default:
                            break;
                    }
                    
                }
                MessageBox.Show("Transferencias realizadas con éxito\nRecuerde que en la exportación SIIGO debe seleccionar este último movimiento", "Transferencias", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            else
            {
                dgvTransfer.Rows.Clear();
                this.Close();
            }
        }

        private void dgvPalletOrigin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.dgvPalletOrigin.DoDragDrop(this.dgvPalletOrigin.CurrentRow, DragDropEffects.All);
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtid.Text.Replace("\r\n", "");
                FillPallet(txtid.Text);
            }
        }

        private void FillPallet(string code)
        {
            clsPallet ObjPallet = new clsPallet();
            ObjPallet = clsPallet.getCompleteDetailByCode(code);
            if (ObjPallet.codsec > 0)
            {
                dgvPalletOrigin.Rows.Add();
                dgvPalletOrigin.Rows[dgvPalletOrigin.Rows.Count - 1].Cells[clmcodsec.Index].Value = ObjPallet.codsec;
                dgvPalletOrigin.Rows[dgvPalletOrigin.Rows.Count - 1].Cells[clmcellarname.Index].Value = ObjPallet.coilCellarName;
                dgvPalletOrigin.Rows[dgvPalletOrigin.Rows.Count - 1].Cells[clmcode.Index].Value = ObjPallet.code;
                dgvPalletOrigin.Rows[dgvPalletOrigin.Rows.Count - 1].Cells[clmorigin.Index].Value = clsPallet.getOrgin(ObjPallet.codsec);
                dgvPalletOrigin.Rows[dgvPalletOrigin.Rows.Count - 1].Cells[clmnetweigth.Index].Value = Math.Round(ObjPallet.netWeight, 1);
                dgvPalletOrigin.Rows[dgvPalletOrigin.Rows.Count - 1].Cells[clmpalbob.Index].Value = ObjPallet.palletNumber + " - " + ObjPallet.lstCoil.Count;
                dgvPalletOrigin.Rows[dgvPalletOrigin.Rows.Count - 1].Cells[clmnumber.Index].Value = ObjPallet.salesOrderNumber;
                dgvPalletOrigin.Rows[dgvPalletOrigin.Rows.Count - 1].Cells[clmcustomer.Index].Value = ObjPallet.customerName;
                txtid.Clear();
                txtid.Focus();
                txtid.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("El pallet ingreso no existe por favor verificar que el código ingreso éste correcto", "Transferencia de Bodega", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                txtid.Clear();
                txtid.Focus();
            }
        }

        private void frmChangeCellar_Load(object sender, EventArgs e)
        {
            //FillCelllar();
        }

        private void FillCelllar()
        {
            List<clsCoilCellar> lstCellar = new List<clsCoilCellar>();
            lstCellar = clsCoilCellar.getList();
            cmbCellar.Items.Clear();
            for (int i = 0; i < lstCellar.Count; i++)
                cmbCellar.Items.Add(lstCellar[i]);
        }
    }
}
