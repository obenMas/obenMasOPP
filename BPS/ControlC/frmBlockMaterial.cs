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
    public partial class frmBlockMaterial : Form
    {
        public bool isAutoricet = false;

        bool isblock = false, isunblock = false, islotnumber = false, iscoil = false;

        public frmBlockMaterial()
        {
            frmCCLogin winLogin = new frmCCLogin(this);
            winLogin.ShowDialog(this);

            if (isAutoricet)
            {
                InitializeComponent();
                pnlActions.Enabled = false;
                grpbDetails.Visible = false;
                grpbSave.Visible = false;
            }
            else
                this.Close();
        }

        private void rdbblock_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbblock.Checked)
            {
                isblock = true;
                pnlActions.Enabled = true;
            }
            else
            {
                isblock = false;
                pnlActions.Enabled = false;
            }
        }

        private void rdbunblock_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbunblock.Checked)
            {
                isunblock = true;
                pnlActions.Enabled = true;
            }
            else
            {
                isunblock = false;
                pnlActions.Enabled = false;
            }
        }

        private void rdblotnumber_CheckedChanged(object sender, EventArgs e)
        {
            if (rdblotnumber.Checked)
            {
                grpbDetails.Visible = true;
                tbcMain.TabPages.Clear();
                tbcMain.TabPages.Insert(0, tbplotnumber);
                PopulateLotNumber();
                grpbSave.Visible = true;
                if (rdbblock.Checked)
                {
                    lblheadlotnumber.Text = rdbblock.Text + " - " + rdblotnumber.Text;
                    isblock = true;
                    islotnumber = true;
                }
                else
                {
                    lblheadlotnumber.Text = rdbunblock.Text + " - " + rdblotnumber.Text;
                    isunblock = true;
                    islotnumber = true;
                }
            }
        }

        private void PopulateLotNumber()
        {
            List<clsFilmProductionPlan> lstFilmProductionOrder = new List<clsFilmProductionPlan>();
            lstFilmProductionOrder = clsFilmProductionPlan.getListByLotNumeber();
            cmblotnumber.Text = "";
            cmblotnumber.SelectedIndex = -1;
            cmblotnumber.Items.Clear();
            for (int i = 0; i < lstFilmProductionOrder.Count; i++)
                cmblotnumber.Items.Add(lstFilmProductionOrder[i]);
        }

        private void rdbcoil_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbcoil.Checked)
            {
                grpbDetails.Visible = true;
                PopulateLotNumber();
                tbcMain.TabPages.Clear();
                tbcMain.TabPages.Insert(0, tbpcoil);
                grpbSave.Visible = true;
                if (rdbblock.Checked)
                {
                    lblheadcoil.Text = rdbblock.Text + " - " + rdbcoil.Text;
                    isblock = true;
                    iscoil = true;
                }
                else
                {
                    lblheadcoil.Text = rdbunblock.Text + " - " + rdbcoil.Text;
                    isunblock = true;
                    iscoil = true;
                }
            }
        }

        private void txtlotnumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PopulateCoil(txtlotnumber.Text);
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvLotnumber.Rows.Count > 0)
            {
                if (chkAll.Checked == true)
                {
                    for (int i = 0; i < dgvLotnumber.Rows.Count; i++)
                    {
                        dgvLotnumber.Rows[i].Cells[clmblockselect.Index].Value = global::BPS.Properties.Resources.accept;
                        dgvLotnumber.Rows[i].Cells[clmblockvalidate.Index].Value = 1;
                        dgvLotnumber.FirstDisplayedScrollingRowIndex = i;
                    }
                }
                else
                {
                    if (MessageBox.Show("Esta realmente seguro que desea eliminar la selección?", "Bloqueo Material", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.OK)
                    {
                        for (int i = 0; i < dgvLotnumber.Rows.Count; i++)
                        {
                            dgvLotnumber.Rows[i].Cells[clmblockselect.Index].Value = global::BPS.Properties.Resources.clear;
                            dgvLotnumber.Rows[i].Cells[clmblockvalidate.Index].Value = 0;
                            dgvLotnumber.FirstDisplayedScrollingRowIndex = i;
                        }
                        chkAll.Checked = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("No existen bobinas que seleccionar", "Bloqueo Material", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                cmblotnumber.Focus();
            }
        }

        private void cmblotnumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmblotnumber.SelectedIndex > -1)
                PopulateCoil(((clsFilmProductionPlan)cmblotnumber.SelectedItem).lotNumber);
        }

        private void PopulateCoil(string lotnumber)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            lstCoil = clsCoil.getCoilListByLotNumber(lotnumber);
            dgvLotnumber.Rows.Clear();
            if (lstCoil.Count > 0)
            {
                for (int i = 0; i < lstCoil.Count; i++)
                {
                    dgvLotnumber.Rows.Add();
                    dgvLotnumber.Rows[i].Cells[clmblockvalidate.Index].Value = 0;
                    dgvLotnumber.Rows[i].Cells[clmblockcodsec.Index].Value = lstCoil[i].codsec;
                    dgvLotnumber.Rows[i].Cells[clmblockcode.Index].Value = lstCoil[i].code;
                    dgvLotnumber.Rows[i].Cells[clmblockproduct.Index].Value = lstCoil[i].ProductCode;
                    dgvLotnumber.Rows[i].Cells[clmblocknetweigth.Index].Value = Math.Round(lstCoil[i].netWeight, 2, MidpointRounding.AwayFromZero);
                    dgvLotnumber.Rows[i].Cells[clmblockmaincoil.Index].Value = lstCoil[i].mainCoilCode;
                    dgvLotnumber.Rows[i].Cells[clmblocklotnumber.Index].Value = lstCoil[i].lotNumber;
                    dgvLotnumber.Rows[i].Cells[clmblockdensity.Index].Value = lstCoil[i].density;
                    dgvLotnumber.Rows[i].Cells[clmblockdate.Index].Value = lstCoil[i].cuttingDate.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvLotnumber.Rows[i].Cells[clmblockselect.Index].Value = global::BPS.Properties.Resources.clear;
                }
            }
            else
            {
                lstCoil = clsCoil.getCoilListByLotNumberExteernalCoil(txtlotnumber.Text);
                if (lstCoil.Count > 0)
                {
                    for (int i = 0; i < lstCoil.Count; i++)
                    {
                        dgvLotnumber.Rows.Add();
                        dgvLotnumber.Rows[i].Cells[clmblockvalidate.Index].Value = 0;
                        dgvLotnumber.Rows[i].Cells[clmblockcodsec.Index].Value = lstCoil[i].codsec;
                        dgvLotnumber.Rows[i].Cells[clmblockcode.Index].Value = lstCoil[i].code;
                        dgvLotnumber.Rows[i].Cells[clmblockproduct.Index].Value = lstCoil[i].ProductCode;
                        dgvLotnumber.Rows[i].Cells[clmblocknetweigth.Index].Value = Math.Round(lstCoil[i].netWeight, 2, MidpointRounding.AwayFromZero);
                        dgvLotnumber.Rows[i].Cells[clmblockmaincoil.Index].Value = lstCoil[i].mainCoilCode;
                        dgvLotnumber.Rows[i].Cells[clmblocklotnumber.Index].Value = lstCoil[i].lotNumber;
                        dgvLotnumber.Rows[i].Cells[clmblockdensity.Index].Value = lstCoil[i].density;
                        dgvLotnumber.Rows[i].Cells[clmblockdate.Index].Value = lstCoil[i].cuttingDate.ToString("dd/MM/yyyy HH:mm:ss");
                        dgvLotnumber.Rows[i].Cells[clmblockselect.Index].Value = global::BPS.Properties.Resources.clear;
                    }
                }
                else
                {
                    MessageBox.Show("No existen datos con el lote seleccionado", "Bloqueo Material", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    cmblotnumber.Focus();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isblock && islotnumber)
            {
                List<int> lstCodsec = new List<int> ();

                for (int i = 0; i < dgvLotnumber.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvLotnumber.Rows[i].Cells[clmblockvalidate.Index].Value) == 1)
                        lstCodsec.Add(Convert.ToInt32(dgvLotnumber.Rows[i].Cells[clmblockcodsec.Index].Value));
                }

                if (clsCoil.saveBlockUnblock(lstCodsec, isblock))
                {
                    MessageBox.Show("Bobinas bloqueadas correctamente!!", "Bloqueo Material", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    ClearForm();
                }
            }
            else if (isunblock && islotnumber)
            {
                List<int> lstCodsec = new List<int>();

                for (int i = 0; i < dgvLotnumber.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvLotnumber.Rows[i].Cells[clmblockvalidate.Index].Value) == 1)
                        lstCodsec.Add(Convert.ToInt32(dgvLotnumber.Rows[i].Cells[clmblockcodsec.Index].Value));
                }

                if (clsCoil.saveBlockUnblock(lstCodsec, isblock))
                {
                    MessageBox.Show("Bobinas desbloqueadas correctamente!!", "Bloqueo Material", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    ClearForm();
                }
            }
        }

        private void ClearForm()
        {
            dgvLotnumber.Rows.Clear();
            cmblotnumber.Text = "";
            cmblotnumber.SelectedIndex = -1;
            grpbDetails.Visible = false;
            rdblotnumber.Checked = false;
            islotnumber = false;
            dgvCoil.Rows.Clear();
            txtCode.Clear();
            rdbcoil.Checked = false;
            iscoil = false;
        }

        private void dgvLotnumber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmblockselect.Index)
            {
                if (dgvLotnumber.Rows[e.RowIndex].Cells[clmblockvalidate.Index].Value.ToString() != "0")
                {
                    dgvLotnumber.Rows[e.RowIndex].Cells[clmblockselect.Index].Value = global::BPS.Properties.Resources.clear;
                    dgvLotnumber.Rows[e.RowIndex].Cells[clmblockvalidate.Index].Value = 0;
                }
                else
                {
                    dgvLotnumber.Rows[e.RowIndex].Cells[clmblockselect.Index].Value = global::BPS.Properties.Resources.accept;
                    dgvLotnumber.Rows[e.RowIndex].Cells[clmblockvalidate.Index].Value = 1;
                }
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PopulateCoilByCoil(txtCode.Text);
        }

        private void PopulateCoilByCoil(string code)
        {
            clsCoil ObjCoil = new clsCoil();
            ObjCoil = clsCoil.getDetailByCode(txtCode.Text);
            if (ObjCoil.codsec > 0)
            {
                dgvCoil.Rows.Add();
                dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilvalidate.Index].Value = 0;
                dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilcodsec.Index].Value = ObjCoil.codsec;
                dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilcode.Index].Value = ObjCoil.code;
                dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilproduct.Index].Value = ObjCoil.ProductCode;
                dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilnetweigth.Index].Value = Math.Round(ObjCoil.netWeight, 2, MidpointRounding.AwayFromZero);
                dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilmaincoil.Index].Value = ObjCoil.mainCoilCode;
                dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoillotnumber.Index].Value = ObjCoil.lotNumber;
                dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoildensity.Index].Value = ObjCoil.density;
                dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoildate.Index].Value = ObjCoil.cuttingDate.ToString("dd/MM/yyyy HH:mm:ss");
                dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilselect.Index].Value = global::BPS.Properties.Resources.clear;
                txtCode.Clear();
                txtCode.Focus();
            }
            else
            {
                MessageBox.Show("No existen datos con al bobina ingresada", "Bloqueo Material", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                cmblotnumber.Focus();
            }
        }

        private void btnSaveCoil_Click(object sender, EventArgs e)
        {
            if (isblock && iscoil)
            {
                List<int> lstCodsec = new List<int>();

                for (int i = 0; i < dgvCoil.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvCoil.Rows[i].Cells[clmcoilvalidate.Index].Value) == 1)
                        lstCodsec.Add(Convert.ToInt32(dgvCoil.Rows[i].Cells[clmcoilcodsec.Index].Value));
                }

                if (clsCoil.saveBlockUnblock(lstCodsec, isblock))
                {
                    MessageBox.Show("Bobinas bloqueadas correctamente!!", "Bloqueo Material", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    ClearForm();
                }
            }
            else if (isunblock && iscoil)
            {
                List<int> lstCodsec = new List<int>();

                for (int i = 0; i < dgvCoil.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvCoil.Rows[i].Cells[clmcoilvalidate.Index].Value) == 1)
                        lstCodsec.Add(Convert.ToInt32(dgvCoil.Rows[i].Cells[clmcoilcodsec.Index].Value));
                }

                if (clsCoil.saveBlockUnblock(lstCodsec, isblock))
                {
                    MessageBox.Show("Bobinas desbloqueadas correctamente!!", "Bloqueo Material", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    ClearForm();
                }
            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvCoil.Rows.Count > 0)
            {
                if (chkSelectAll.Checked == true)
                {
                    for (int i = 0; i < dgvCoil.Rows.Count; i++)
                    {
                        dgvCoil.Rows[i].Cells[clmcoilselect.Index].Value = global::BPS.Properties.Resources.accept;
                        dgvCoil.Rows[i].Cells[clmcoilvalidate.Index].Value = 1;
                        dgvCoil.FirstDisplayedScrollingRowIndex = i;
                    }
                }
                else
                {
                    if (MessageBox.Show("Esta realmente seguro que desea eliminar la selección?", "Bloqueo Material", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.OK)
                    {
                        for (int i = 0; i < dgvCoil.Rows.Count; i++)
                        {
                            dgvCoil.Rows[i].Cells[clmcoilselect.Index].Value = global::BPS.Properties.Resources.clear;
                            dgvCoil.Rows[i].Cells[clmcoilvalidate.Index].Value = 0;
                            dgvCoil.FirstDisplayedScrollingRowIndex = i;
                        }
                        chkSelectAll.Checked = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("No existen bobinas que seleccionar", "Bloqueo Material", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                cmblotnumber.Focus();
            }
        }

        private void dgvCoil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmcoilselect.Index)
            {
                if (dgvCoil.Rows[e.RowIndex].Cells[clmcoilvalidate.Index].Value.ToString() != "0")
                {
                    dgvCoil.Rows[e.RowIndex].Cells[clmcoilselect.Index].Value = global::BPS.Properties.Resources.clear;
                    dgvCoil.Rows[e.RowIndex].Cells[clmcoilvalidate.Index].Value = 0;
                }
                else
                {
                    dgvCoil.Rows[e.RowIndex].Cells[clmcoilselect.Index].Value = global::BPS.Properties.Resources.accept;
                    dgvCoil.Rows[e.RowIndex].Cells[clmcoilvalidate.Index].Value = 1;
                }
            }
        }
    }
}
