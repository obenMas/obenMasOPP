using System;
using System.Drawing;
using System.Windows.Forms;
using BPS.Bussiness;
using System.Collections.Generic;

namespace BPS.Raw.Process.Out
{
    public partial class frmOutRaw : Form
    {
        #region Init
        private string type = string.Empty, source = string.Empty;
        private clsRawMaterial objRaw = new clsRawMaterial();
        List<pltList> pltListL = new List<pltList>();

        public frmOutRaw()
        {
            InitializeComponent();
        }

        public frmOutRaw(string source, string type)
        {
            InitializeComponent();
            this.type = type;
            this.source = source;
            this.Text = source;
            tbpPallets.Text = "Requerimiento " + source;
        }

        #endregion

        #region Helper

        class pltList
        {
            public string message { get; set; }
        }

        private void ReCountRows()
        {
            for (int i = 0; i < dgvPallets.Rows.Count; i++)
                dgvPallets.Rows[i].Cells[clmnumber.Index].Value = (i + 1);
        }

        #endregion

        #region Actions

        private void txtPalletCode_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtPalletCode.Text.Trim().ToUpper() == "PROCESS")
                        processPallet();
                    else if (!string.IsNullOrEmpty(txtPalletCode.Text))
                        addPallet(txtPalletCode.Text.Trim());
                    else if (txtPalletCode.Text.Trim().ToUpper() == "CANCEL" || txtPalletCode.Text.Trim().ToUpper() == "BACK")
                        cancelPallet();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Movimientos de bodega", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void addPallet(string code)
        {
            objRaw = new clsRawMaterial();
            objRaw = clsRawMaterial.getRawByCode(code, type);

            if (objRaw.codsec > 0 && string.IsNullOrEmpty(objRaw.message))
            {
                dgvPallets.Rows.Add();
                dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmnumber.Index].Value = (dgvPallets.Rows.Count == 1) ? 1 : dgvPallets.Rows.Count;
                dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletCodsec.Index].Value = objRaw.codsec;
                dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletCode.Index].Value = objRaw.code;
                dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletTypeProductMP.Index].Value = objRaw.RawMaterialtypeName;
                dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletMPCode.Index].Value = objRaw.RawMaterialCode;
                dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletLotNumber.Index].Value = objRaw.lotNumber;
                dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletNetWeight.Index].Value = Math.Round(objRaw.netWeigth, 1);
                dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletGrossWeight.Index].Value = Math.Round(objRaw.grossWeigth, 1);
                dgvPallets.Rows[dgvPallets.Rows.Count - 1].Cells[clmPalletStatus.Index].Value = global::BPS.Raw.Properties.Resources.clear;
                txtPalletCode.Text = "";
                txtPalletCode.Focus();
            }
            else
            {
                if (objRaw.codsec == 0)
                {
                    pltListL.Add(new pltList());
                    pltListL[pltListL.Count - 1].message = "El código " + code + ", no existe \n";
                    txtPalletCode.Text = "";
                    txtPalletCode.Focus();
                }
                else
                {
                    pltListL.Add(new pltList());
                    pltListL[pltListL.Count - 1].message = objRaw.message;
                    txtPalletCode.Text = "";
                    txtPalletCode.Focus();
                }
            }
        }

        private void cancelPallet()
        {
            if (MessageBox.Show("Está realmente seguro que desea cancelar los movimientos", "Movimientos Bodega", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                txtPalletCode.Text = "";
                dgvPallets.Rows.Clear();
            }
            else
            {
                txtPalletCode.Text = "";
                txtPalletCode.Focus();
            }
        }

        private void processPallet()
        {
            string msn = "";

            for (int i = 0; i < dgvPallets.Rows.Count; i++)
            {
                objRaw = new clsRawMaterial();

                if (clsRawMaterialbyCoilCellar.setTransferM(dgvPallets.Rows[i].Cells[clmPalletCodsec.Index].Value.ToString()))
                {
                    if (clsRawMaterialbyCoilCellar.setTransfer(dgvPallets.Rows[i].Cells[clmPalletCodsec.Index].Value.ToString(), source, type))
                        dgvPallets.Rows[i].Cells[clmPalletStatus.Index].Value = global::BPS.Raw.Properties.Resources.check;
                    else
                    {
                        dgvPallets.Rows[i].Cells[clmPalletStatus.Index].Value = global::BPS.Raw.Properties.Resources.cross;
                        pltListL.Add(new pltList());
                        pltListL[pltListL.Count - 1].message = "No es posible procesar el pallet con código " + dgvPallets.Rows[i].Cells[clmPalletCode.Index].Value + " \n esto puede deberse a los siguientes motivos: \n -El pallet no existe en la bodega de MP \n -La materia prima del pallet no coincide con la almacenada en el silo";
                    }
                }
                else
                {
                    dgvPallets.Rows[i].Cells[clmPalletStatus.Index].Value = global::BPS.Raw.Properties.Resources.cross;
                    pltListL.Add(new pltList());
                    pltListL[pltListL.Count - 1].message = "No es posible actualizar el movimiento del pallet con código " + dgvPallets.Rows[i].Cells[clmPalletCode.Index].Value + " \n";
                }
            }

            txtPalletCode.Text = "";
            txtPalletCode.Focus();

            if (pltListL.Count > 0)
            {
                foreach (var item in pltListL)
                {
                    msn += item.message;
                }

                MessageBox.Show("El proceso de pallet mostró las siguientes novedades: \n" + msn, "Devoluciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

                pltListL.Clear();
            }
        }

        private void dgvPallets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmnumber.Index)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar el pallet seleccionado", "Movimientos de bodega", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    dgvPallets.Rows.RemoveAt(e.RowIndex);
                    ReCountRows();
                }
            }
        }

        #endregion
    }
}
