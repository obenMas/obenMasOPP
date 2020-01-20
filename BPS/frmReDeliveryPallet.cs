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
    public partial class frmReDeliveryPallet : Form
    {
        List<string> lstPallet = new List<string>();
        public bool isAutoricet = false;

        public frmReDeliveryPallet()
        {
            frmCellarLogin winLogin = new frmCellarLogin(this);
            winLogin.ShowDialog(this);

            if (isAutoricet)
                InitializeComponent();
            else
                this.Close();
        }

        private void frmReDeliveryPallet_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
        }

        private void txtcodepallet_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtcodepallet.Text == "Process")
                        ProcessMovement();
                else
                    AddInventory(txtcodepallet.Text);
            }
        }

        private void AddInventory(string code)
        {
            try
            {
                clsPallet ObjPallet = new clsPallet();
                ObjPallet = clsPallet.getDetailByCode(code);
                if (ObjPallet.codsec > 0)
                {
                    dgvPallet.Rows.Add();
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmnumber.Index].Value = (dgvPallet.Rows.Count == 0) ? 1 : dgvPallet.Rows.Count;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmfkpallet.Index].Value = ObjPallet.codsec;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmcode.Index].Value = ObjPallet.code;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmproduct.Index].Value = ObjPallet.product.code;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmcoilcellar.Index].Value = ObjPallet.coilCellarName;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmpalletnumberandcoilnumber.Index].Value = ObjPallet.palletNumber + '-' + ObjPallet.lstCoil.Count;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmnetweigth.Index].Value = Math.Round(ObjPallet.netWeight, 1);
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmdelivery.Index].Value = ObjPallet.delivery;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmsalesnumber.Index].Value = ObjPallet.salesOrderNumber;
                    dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmcustomer.Index].Value = ObjPallet.customerName;
                    lstPallet.Add(ObjPallet.code);
                    txtcodepallet.Clear();
                    txtcodepallet.Focus();
                }
                else
                    MessageBox.Show("Pallet no existe", "Re - Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Re - Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void ProcessMovement()
        {
            if (dgvPallet.Rows.Count > 0)
            {
                clsPallet.setUpdateStatusWhenNotDeliveryPallet(lstPallet);
                MessageBox.Show("Pallet´s re-ingresados correctamente\nPor favor verifique el re-ingreso en el Backload", "Re - Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                this.Close();
            }
            else
                MessageBox.Show("No existen datos para realizar el re-ingreso", "Re - Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification, true);
        }
    }
}
