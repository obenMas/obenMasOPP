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
    public partial class frmNationalPalletShipping : Form
    {
        private clsMaquile objMaquile = new clsMaquile();
        private List<stctMyMaquile> lstMyMaquile = new List<stctMyMaquile>();

        private clsMillPallet objMillPallet = new clsMillPallet();
        private clsMillPalletbyCoilCellar objMillPalletByCoilCellar = new clsMillPalletbyCoilCellar();
        private List<stctMyMill> lstMyMill = new List<stctMyMill>();

        private bool isValid = true;

        public frmNationalPalletShipping()
        {
            InitializeComponent();
        }

        private void frmNationalPalletShipping_Load(object sender, EventArgs e)
        {
            txtPalletCode.Focus();
            txtPalletCode.Select();
        }

        private void txtPalletCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (clsPallet.getPalletValidate(txtPalletCode.Text, true) == "OK")
                {
                    if (dgvPalletList.Rows.Count == 0)
                    {
                        dgvPalletList.Rows.Add();
                        dgvPalletList.Rows[0].Cells[clmnumber.Index].Value = (dgvPalletList.Rows.Count == 1) ? 1 : dgvPalletList.Rows.Count;
                        dgvPalletList.Rows[0].Cells[clmCode.Index].Value = txtPalletCode.Text;
                        dgvPalletList.Rows[0].Cells[clmStatus.Index].Value = "Por despachar";
                        dgvPalletList.Rows[0].Cells[clmimage.Index].Value = global::BPS.Properties.Resources.cross;
                        dgvPalletList.Rows[0].Cells[clmblock.Index].Value = global::BPS.Properties.Resources.clear;
                        dgvPalletList.Rows[0].Cells[clmvalidate.Index].Value = 0;
                        txtPalletCode.Text = string.Empty;
                        txtPalletCode.Focus();
                    }
                    else
                    {
                        dgvPalletList.Rows.Add();
                        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[clmnumber.Index].Value = (dgvPalletList.Rows.Count == 1) ? 1 : dgvPalletList.Rows.Count;
                        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[clmCode.Index].Value = txtPalletCode.Text;
                        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[clmStatus.Index].Value = "Por despachar";
                        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[clmimage.Index].Value = global::BPS.Properties.Resources.cross;
                        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[clmblock.Index].Value = global::BPS.Properties.Resources.clear;
                        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[clmvalidate.Index].Value = 0;
                        txtPalletCode.Text = string.Empty;
                        txtPalletCode.Focus();
                    }
                }
                else
                {
                    if (dgvPalletList.Rows.Count == 0)
                    {
                        dgvPalletList.Rows.Add();
                        dgvPalletList.Rows[0].Cells[clmnumber.Index].Value = (dgvPalletList.Rows.Count == 1) ? 1 : dgvPalletList.Rows.Count;
                        dgvPalletList.Rows[0].Cells[clmCode.Index].Value = txtPalletCode.Text;
                        dgvPalletList.Rows[0].Cells[clmStatus.Index].Value = "Por despachar";
                        dgvPalletList.Rows[0].Cells[clmimage.Index].Value = global::BPS.Properties.Resources.clear;
                        dgvPalletList.Rows[0].Cells[clmblock.Index].Value = global::BPS.Properties.Resources.key;
                        dgvPalletList.Rows[0].Cells[clmvalidate.Index].Value = 1;
                        for (int j = 0; j < dgvPalletList.Rows[0].Cells.Count; j++)
                        {
                            Font fntBold = new Font(dgvPalletList.Font, FontStyle.Bold);
                            dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                            dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                        }
                        txtPalletCode.Text = string.Empty;
                        txtPalletCode.Focus();
                    }
                    else
                    {
                        dgvPalletList.Rows.Add();
                        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[clmnumber.Index].Value = (dgvPalletList.Rows.Count == 1) ? 1 : dgvPalletList.Rows.Count;
                        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[clmCode.Index].Value = txtPalletCode.Text;
                        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[clmStatus.Index].Value = "Por despachar";
                        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[clmimage.Index].Value = global::BPS.Properties.Resources.clear;
                        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[clmblock.Index].Value = global::BPS.Properties.Resources.key;
                        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[clmvalidate.Index].Value = 1;
                        for (int j = 0; j < dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells.Count; j++)
                        {
                            Font fntBold = new Font(dgvPalletList.Font, FontStyle.Bold);
                            dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                            dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                        }
                        txtPalletCode.Text = string.Empty;
                        txtPalletCode.Focus();
                    }
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
            try
            {
                if (MessageBox.Show("Está seguro que se desea despachar los pallets ingresados?...", "Despacho", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    List<string> lstPalletString = new List<string>();
                    for (int i = 0; i < dgvPalletList.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dgvPalletList.Rows[i].Cells[clmvalidate.Index].Value) == 0)
                            lstPalletString.Add(dgvPalletList.Rows[i].Cells[clmCode.Index].Value.ToString());
                    }
                    lstPalletString = lstPalletString.Distinct().ToList();
                    clsPallet.setPalletAsDeliveredNational(lstPalletString);
                    MessageBox.Show("Despachos realizados correctamente", "Despachos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GenerateSummary(lstPalletString);
                    tbcShippingPalletFull.SelectTab(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Despachos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
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

        private void txtMaquileCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (clsMaquile.getMaquileByCode(txtMaquileCode.Text))
                {
                    objMaquile = new clsMaquile();

                    if (dgvMaquile.Rows.Count == 0)
                    {
                        objMaquile = clsMaquile.getMaquileObjByCode(txtMaquileCode.Text);
                        dgvMaquile.Rows.Add();
                        dgvMaquile.Rows[0].Cells[clmmaquilecodsec.Index].Value = objMaquile.codsec;
                        dgvMaquile.Rows[0].Cells[clmmaquilenumber.Index].Value = (dgvMaquile.Rows.Count == 1) ? 1 : dgvMaquile.Rows.Count;
                        dgvMaquile.Rows[0].Cells[clmmaquilecode.Index].Value = txtMaquileCode.Text;
                        dgvMaquile.Rows[0].Cells[clmmaquilecustomer.Index].Value = objMaquile.customer;
                        dgvMaquile.Rows[0].Cells[clmmaquileproduct.Index].Value = objMaquile.product;
                        dgvMaquile.Rows[0].Cells[clmmaquilebase.Index].Value = objMaquile.name + " - " + objMaquile.reference;
                        dgvMaquile.Rows[0].Cells[clmmaquileweigth.Index].Value = Math.Round(objMaquile.weigth, 2);
                        dgvMaquile.Rows[0].Cells[clmmaquilestatus.Index].Value = global::BPS.Properties.Resources.clear;
                        dgvMaquile.Rows[0].Cells[clmmaquiledelete.Index].Value = global::BPS.Properties.Resources.cross;
                        dgvMaquile.Rows[0].Cells[clmmaquileinfo.Index].Value = "OK";
                        txtMaquileCode.Text = string.Empty;
                        txtMaquileCode.Focus();
                    }
                    else
                    {
                        objMaquile = clsMaquile.getMaquileObjByCode(txtMaquileCode.Text);
                        dgvMaquile.Rows.Add();
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilecodsec.Index].Value = objMaquile.codsec;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilenumber.Index].Value = (dgvMaquile.Rows.Count == 1) ? 1 : dgvMaquile.Rows.Count;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilecode.Index].Value = txtMaquileCode.Text;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilecustomer.Index].Value = objMaquile.customer;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquileproduct.Index].Value = objMaquile.product;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilebase.Index].Value = objMaquile.name + " - " + objMaquile.reference;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquileweigth.Index].Value = Math.Round(objMaquile.weigth, 2);
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilestatus.Index].Value = global::BPS.Properties.Resources.clear;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquiledelete.Index].Value = global::BPS.Properties.Resources.cross;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquileinfo.Index].Value = "OK";
                        txtMaquileCode.Text = string.Empty;
                        txtMaquileCode.Focus();
                    }
                }
                else
                {
                    dgvMaquile.Rows.Add();
                    dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilecodsec.Index].Value = 0;
                    dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilenumber.Index].Value = (dgvMaquile.Rows.Count == 1) ? 1 : dgvMaquile.Rows.Count;
                    dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilecode.Index].Value = txtMaquileCode.Text;
                    dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilecustomer.Index].Value = "--------";
                    dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquileproduct.Index].Value = "--------";
                    dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilebase.Index].Value = "--------";
                    dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquileweigth.Index].Value = "--------";
                    dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilestatus.Index].Value = global::BPS.Properties.Resources.cross;
                    dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquiledelete.Index].Value = global::BPS.Properties.Resources.cross;
                    dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquileinfo.Index].Value = "DO";
                    txtMaquileCode.Text = string.Empty;
                    txtMaquileCode.Focus();

                    for (int j = 0; j < dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells.Count; j++)
                    {
                        Font fntBold = new Font(dgvMaquile.Font, FontStyle.Bold);
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                    }
                }
            }
        }

        private void btnShippingMaquile_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMaquile.Rows.Count > 0)
                {
                    if (MessageBox.Show("Está realmente seguro que desea despachas las maquilas ingresadas??", "Maquilas-Metalizadas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dgvMaquile.Rows.Count; i++)
                        {
                            if (dgvMaquile.Rows[i].Cells[clmmaquileinfo.Index].Value.ToString() == "OK")
                            {
                                if (toSendMaquile(Convert.ToInt32(dgvMaquile.Rows[i].Cells[clmmaquilecodsec.Index].Value)))
                                {
                                    if (lstMyMaquile.Count == 0)
                                    {
                                        lstMyMaquile.Add(new stctMyMaquile());
                                        lstMyMaquile[0].number = Convert.ToInt32(dgvMaquile.Rows[i].Cells[clmmaquilenumber.Index].Value);
                                        lstMyMaquile[0].codsec = Convert.ToInt32(dgvMaquile.Rows[i].Cells[clmmaquilecodsec.Index].Value);
                                        lstMyMaquile[0].code = dgvMaquile.Rows[i].Cells[clmmaquilecode.Index].Value.ToString();
                                        lstMyMaquile[0].customer = dgvMaquile.Rows[i].Cells[clmmaquilecustomer.Index].Value.ToString();
                                        lstMyMaquile[0].bases = dgvMaquile.Rows[i].Cells[clmmaquileproduct.Index].Value.ToString();
                                        lstMyMaquile[0].product = dgvMaquile.Rows[i].Cells[clmmaquilebase.Index].Value.ToString();
                                        lstMyMaquile[0].weightTotal = Convert.ToDouble(dgvMaquile.Rows[i].Cells[clmmaquileweigth.Index].Value);
                                        lstMyMaquile[0].status = true;
                                    }
                                    else
                                    {
                                        lstMyMaquile.Add(new stctMyMaquile());
                                        lstMyMaquile[lstMyMaquile.Count - 1].number = Convert.ToInt32(dgvMaquile.Rows[i].Cells[clmmaquilenumber.Index].Value);
                                        lstMyMaquile[lstMyMaquile.Count - 1].codsec = Convert.ToInt32(dgvMaquile.Rows[i].Cells[clmmaquilecodsec.Index].Value);
                                        lstMyMaquile[lstMyMaquile.Count - 1].code = dgvMaquile.Rows[i].Cells[clmmaquilecode.Index].Value.ToString();
                                        lstMyMaquile[lstMyMaquile.Count - 1].customer = dgvMaquile.Rows[i].Cells[clmmaquilecustomer.Index].Value.ToString();
                                        lstMyMaquile[lstMyMaquile.Count - 1].bases = dgvMaquile.Rows[i].Cells[clmmaquileproduct.Index].Value.ToString();
                                        lstMyMaquile[lstMyMaquile.Count - 1].product = dgvMaquile.Rows[i].Cells[clmmaquilebase.Index].Value.ToString();
                                        lstMyMaquile[lstMyMaquile.Count - 1].weightTotal = Convert.ToDouble(dgvMaquile.Rows[i].Cells[clmmaquileweigth.Index].Value);
                                        lstMyMaquile[lstMyMaquile.Count - 1].status = true;
                                    }
                                }
                                else
                                {
                                    isValid = false;
                                    MessageBox.Show("La información no ha podido ser procesada", "Maquilas-Metalizadas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                    break;
                                }
                            }
                        }
                        if (isValid)
                            RealaodMaquile(lstMyMaquile);
                    }
                }
                else
                    MessageBox.Show("No existen datos para despachar", "Maquilas-Metalizadas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Maquilas-Metalizadas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void RealaodMaquile(List<stctMyMaquile> lstMyMaquile)
        {
            dgvMaquile.Rows.Clear();
            for (int i = 0; i < lstMyMaquile.Count; i++)
            {
                dgvMaquile.Rows.Add();
                dgvMaquile.Rows[i].Cells[clmmaquilenumber.Index].Value = (dgvMaquile.Rows.Count == 1) ? 1 : dgvMaquile.Rows.Count;
                dgvMaquile.Rows[i].Cells[clmmaquilecode.Index].Value = lstMyMaquile[i].code;
                dgvMaquile.Rows[i].Cells[clmmaquilecustomer.Index].Value = lstMyMaquile[i].customer;
                dgvMaquile.Rows[i].Cells[clmmaquileproduct.Index].Value = lstMyMaquile[i].bases;
                dgvMaquile.Rows[i].Cells[clmmaquilebase.Index].Value = lstMyMaquile[i].product;
                dgvMaquile.Rows[i].Cells[clmmaquileweigth.Index].Value = Math.Round(lstMyMaquile[i].weightTotal, 2);
                dgvMaquile.Rows[i].Cells[clmmaquilestatus.Index].Value = global::BPS.Properties.Resources.check;
                dgvMaquile.Rows[i].Cells[clmmaquiledelete.Index].Value = global::BPS.Properties.Resources.clear;
                dgvMaquile.Rows[i].Cells[clmmaquileinfo.Index].Value = "OK";
            }
        }

        private bool toSendMaquile(int codsec)
        {
            objMaquile.load(codsec);
            objMaquile.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Maquilas", "Despachado").codsec;
            if (objMaquile.save())
            {
                    clsMaquile objMaquileD = new clsMaquile();
                    objMaquileD.code = objMaquile.code;
                    objMaquileD.fkStatus = objMaquile.fkStatus;
                    objMaquileD.fkProduct = objMaquile.fkProduct;
                    objMaquileD.customer = objMaquile.customer;
                    objMaquileD.cellarName = "Despacho";
                    objMaquileD.notes = objMaquile.notes;
                    objMaquileD.weigth = objMaquile.weigth;
                    objMaquileD.movement = "S014";
                    objMaquileD.cellar = "0019";
                    objMaquileD.ingress = false;
                    objMaquileD.outt = true;
                    objMaquileD.boppweigth = objMaquile.weigth;
                    objMaquileD.oppweigth = 0;
                    objMaquileD.pallet = objMaquile.pallet;
                    objMaquileD.coil = objMaquile.coil;
                    objMaquileD.diameter = objMaquile.diameter;
                    objMaquileD.core = objMaquile.core;
                    objMaquileD.width = objMaquile.width;
                    objMaquileD.fkExport = 353;
                    objMaquileD.fkProductFrom = objMaquile.fkProductFrom;
                    objMaquileD.fkProductTo = objMaquile.fkProductTo;
                    objMaquileD.fkmainCoilMetal = objMaquile.fkmainCoilMetal;
                    objMaquileD.mainCoilMetalCode = objMaquile.mainCoilMetalCode;
                    if (objMaquileD.save("Maquile"))
                        return true;
                    else
                        return false;
            }
            else
                return false;
        }

        private class stctMyMaquile
        {
            public int number { get; set; }
            public int codsec { get; set; }
            public string code { get; set; }
            public string customer { get; set; }
            public string bases { get; set; }
            public string product { get; set; }
            public double weightTotal { get; set; }
            public bool status { get; set; }
        }

        private void dgvMaquile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == clmmaquiledelete.Index)
                {
                    if (MessageBox.Show("Está realmente seguro que desea que desea eliminar la maquila seleccionada??", "Maquilas-Metalizadas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    {
                        dgvMaquile.Rows.RemoveAt(e.RowIndex);
                        RefreshNumberMaquile();
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Maquilas-Metalizadas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void RefreshNumberMaquile()
        {
            for (int i = 0; i < dgvMaquile.Rows.Count; i++)
                dgvMaquile.Rows[i].Cells[clmmaquilenumber.Index].Value = (i + 1);
        }

        private void btnNewMaquile_Click(object sender, EventArgs e)
        {
            if (dgvMaquile.Rows.Count > 0)
            {
                if (MessageBox.Show("Existen datos en la grilla esta seguro que desea iniciar un nuevo despacho??", "Maquilas-Metalizadas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    dgvMaquile.Rows.Clear();
                    txtMaquileCode.Text = string.Empty;
                    txtMaquileCode.Focus();
                    lstMyMaquile.Clear();
                } 
            }
            else
            {
                if (MessageBox.Show("Esta por empezar un nuevo despacho desea continuar??", "Maquilas-Metalizadas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    dgvMaquile.Rows.Clear();
                    txtMaquileCode.Text = string.Empty;
                    txtMaquileCode.Focus();
                }
            }
        }

        private void txtReProcessCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ValidateForm())
                {
                    if (clsMillPallet.getMillPalletByCode(txtReProcessCode.Text))
                    {
                        objMillPallet = new clsMillPallet();

                        if (dgvReprocess.Rows.Count == 0)
                        {
                            objMillPallet = clsMillPallet.getObjMillPallet(txtReProcessCode.Text);
                            dgvReprocess.Rows.Add();
                            dgvReprocess.Rows[0].Cells[clmreprocesscodsec.Index].Value = objMillPallet.codsec;
                            dgvReprocess.Rows[0].Cells[clmreprocesspallet.Index].Value = clsMillPalletbyCoilCellar.toCodsecByMillPalletCodsec(objMillPallet.codsec);
                            dgvReprocess.Rows[0].Cells[clmreprocessnumber.Index].Value = (dgvReprocess.Rows.Count == 1) ? 1 : dgvReprocess.Rows.Count;
                            dgvReprocess.Rows[0].Cells[clmreprocesscode.Index].Value = txtReProcessCode.Text;
                            dgvReprocess.Rows[0].Cells[clmreprocesscustomer.Index].Value = objMillPallet.customer;
                            dgvReprocess.Rows[0].Cells[clmreprocessproduct.Index].Value = objMillPallet.ProductName;
                            dgvReprocess.Rows[0].Cells[clmreprocessid.Index].Value = objMillPallet.ProductCode;
                            dgvReprocess.Rows[0].Cells[clmreprocessnetweigth.Index].Value = Math.Round(objMillPallet.netWeigth, 2, MidpointRounding.AwayFromZero);
                            dgvReprocess.Rows[0].Cells[clmreprocessgrossweigth.Index].Value = Math.Round(objMillPallet.grossWeigth, 2, MidpointRounding.AwayFromZero);
                            dgvReprocess.Rows[0].Cells[clmreprocessdensity.Index].Value = Math.Round(objMillPallet.density, 4, MidpointRounding.AwayFromZero);
                            dgvReprocess.Rows[0].Cells[clmreprocesscheck.Index].Value = global::BPS.Properties.Resources.clear;
                            dgvReprocess.Rows[0].Cells[clmreprocessdelete.Index].Value = global::BPS.Properties.Resources.cross;
                            dgvReprocess.Rows[0].Cells[clmreprocessdestination.Index].Value = (rdbCalderon.Checked == true) ? "Bopp Calderón" : (rdbCustomer.Checked) ? "Cliente" : (rdbGye.Checked) ? "Bodega Duran" : "";
                            dgvReprocess.Rows[0].Cells[clmreprocessinfo.Index].Value = "OK";
                            txtReProcessCode.Text = string.Empty;
                            txtReProcessCode.Focus();
                        }
                        else
                        {
                            objMillPallet = clsMillPallet.getObjMillPallet(txtReProcessCode.Text);
                            dgvReprocess.Rows.Add();
                            dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocesscodsec.Index].Value = objMillPallet.codsec;
                            dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocesspallet.Index].Value = clsMillPalletbyCoilCellar.toCodsecByMillPalletCodsec(objMillPallet.codsec);
                            dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessnumber.Index].Value = (dgvReprocess.Rows.Count == 1) ? 1 : dgvReprocess.Rows.Count;
                            dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocesscode.Index].Value = txtReProcessCode.Text;
                            dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocesscustomer.Index].Value = objMillPallet.customer;
                            dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessproduct.Index].Value = objMillPallet.ProductName;
                            dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessid.Index].Value = objMillPallet.ProductCode;
                            dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessnetweigth.Index].Value = Math.Round(objMillPallet.netWeigth, 2, MidpointRounding.AwayFromZero);
                            dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessgrossweigth.Index].Value = Math.Round(objMillPallet.grossWeigth, 2, MidpointRounding.AwayFromZero);
                            dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessdensity.Index].Value = Math.Round(objMillPallet.density, 4, MidpointRounding.AwayFromZero);
                            dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocesscheck.Index].Value = global::BPS.Properties.Resources.clear;
                            dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessdelete.Index].Value = global::BPS.Properties.Resources.cross;
                            dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessdestination.Index].Value = (rdbCalderon.Checked == true) ? "Bopp Calderón" : (rdbCustomer.Checked) ? "Cliente" : (rdbGye.Checked) ? "Bodega Duran" : "";
                            dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessinfo.Index].Value = "OK";
                            txtReProcessCode.Text = string.Empty;
                            txtReProcessCode.Focus();
                        }
                    }
                    else
                    {
                        dgvReprocess.Rows.Add();
                        dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocesscodsec.Index].Value = 0;
                        dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocesspallet.Index].Value = 0;
                        dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessnumber.Index].Value = (dgvReprocess.Rows.Count == 1) ? 1 : dgvReprocess.Rows.Count;
                        dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocesscode.Index].Value = txtReProcessCode.Text;
                        dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocesscustomer.Index].Value = "--------";
                        dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessproduct.Index].Value = "--------";
                        dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessid.Index].Value = "--------";
                        dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessnetweigth.Index].Value = "--------";
                        dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessgrossweigth.Index].Value = "--------";
                        dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessdensity.Index].Value = "--------";
                        dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocesscheck.Index].Value = global::BPS.Properties.Resources.cross;
                        dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessdelete.Index].Value = global::BPS.Properties.Resources.cross;
                        dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessdestination.Index].Value = "--------";
                        dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessinfo.Index].Value = "DO";
                        txtReProcessCode.Text = string.Empty;
                        txtReProcessCode.Focus();

                        for (int j = 0; j < dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells.Count; j++)
                        {
                            Font fntBold = new Font(dgvReprocess.Font, FontStyle.Bold);
                            dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                            dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el destino del despacho antes de descargar los registros", "Maquilas-Metalizadas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    txtReProcessCode.Clear();
                    txtReProcessCode.Focus();
                }
            }
        }

        private bool ValidateForm()
        {
            if (rdbCalderon.Checked || rdbCustomer.Checked || rdbGye.Checked)
                return true;
            else
                return false;
        }

        private void btnProcessReProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReprocess.Rows.Count > 0)
                {
                    if (MessageBox.Show("Está realmente seguro que desea despachar el re-procesado ingresado??", "Re-Procesado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dgvReprocess.Rows.Count; i++)
                        {
                            if (dgvReprocess.Rows[i].Cells[clmreprocessinfo.Index].Value.ToString() == "OK")
                            {
                                if (toSendMillPallet(Convert.ToInt32(dgvReprocess.Rows[i].Cells[clmreprocesscodsec.Index].Value)))
                                {
                                    if (lstMyMill.Count == 0)
                                    {
                                        lstMyMill.Add(new stctMyMill());
                                        lstMyMill[0].number = Convert.ToInt32(dgvReprocess.Rows[i].Cells[clmreprocessnumber.Index].Value);
                                        lstMyMill[0].codsec = Convert.ToInt32(dgvReprocess.Rows[i].Cells[clmreprocesscodsec.Index].Value);
                                        lstMyMill[0].code = dgvReprocess.Rows[i].Cells[clmreprocesscode.Index].Value.ToString();
                                        lstMyMill[0].customer = dgvReprocess.Rows[i].Cells[clmreprocesscustomer.Index].Value.ToString();
                                        lstMyMill[0].id = dgvReprocess.Rows[i].Cells[clmreprocessid.Index].Value.ToString();
                                        lstMyMill[0].product = dgvReprocess.Rows[i].Cells[clmreprocessproduct.Index].Value.ToString();
                                        lstMyMill[0].weightTotal = Convert.ToDouble(dgvReprocess.Rows[i].Cells[clmreprocessnetweigth.Index].Value);
                                        lstMyMill[0].grossTotal = Convert.ToDouble(dgvReprocess.Rows[i].Cells[clmreprocessgrossweigth.Index].Value);
                                        lstMyMill[0].density = Convert.ToDouble(dgvReprocess.Rows[i].Cells[clmreprocessdensity.Index].Value);
                                        lstMyMill[0].status = true;
                                    }
                                    else
                                    {
                                        lstMyMill.Add(new stctMyMill());
                                        lstMyMill[lstMyMill.Count - 1].number = Convert.ToInt32(dgvReprocess.Rows[i].Cells[clmreprocessnumber.Index].Value);
                                        lstMyMill[lstMyMill.Count - 1].codsec = Convert.ToInt32(dgvReprocess.Rows[i].Cells[clmreprocesscodsec.Index].Value);
                                        lstMyMill[lstMyMill.Count - 1].code = dgvReprocess.Rows[i].Cells[clmreprocesscode.Index].Value.ToString();
                                        lstMyMill[lstMyMill.Count - 1].customer = dgvReprocess.Rows[i].Cells[clmreprocesscustomer.Index].Value.ToString();
                                        lstMyMill[lstMyMill.Count - 1].id = dgvReprocess.Rows[i].Cells[clmreprocessid.Index].Value.ToString();
                                        lstMyMill[lstMyMill.Count - 1].product = dgvReprocess.Rows[i].Cells[clmreprocessproduct.Index].Value.ToString();
                                        lstMyMill[lstMyMill.Count - 1].weightTotal = Convert.ToDouble(dgvReprocess.Rows[i].Cells[clmreprocessnetweigth.Index].Value);
                                        lstMyMill[lstMyMill.Count - 1].grossTotal = Convert.ToDouble(dgvReprocess.Rows[i].Cells[clmreprocessgrossweigth.Index].Value);
                                        lstMyMill[lstMyMill.Count - 1].density = Convert.ToDouble(dgvReprocess.Rows[i].Cells[clmreprocessdensity.Index].Value);
                                        lstMyMill[lstMyMill.Count - 1].status = true;
                                    }
                                }
                                else
                                {
                                    isValid = false;
                                    MessageBox.Show("La información no ha podido ser procesada", "Re - Procesado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                    break;
                                }
                            }
                        }
                        if (isValid)
                            RealaodMill(lstMyMill);
                    }
                }
                else
                    MessageBox.Show("No existen datos para despachar", "Maquilas-Metalizadas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Maquilas-Metalizadas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private bool toSendMillPallet(int codsec)
        {
            if (clsMillPalletbyCoilCellar.toShipping(codsec))
            {
                if (rdbCalderon.Checked)
                {
                    objMillPallet.load(codsec);
                    objMillPalletByCoilCellar = new clsMillPalletbyCoilCellar();
                    objMillPalletByCoilCellar.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Molinos", "Despacho").codsec;
                    objMillPalletByCoilCellar.fkmillpallet = codsec;
                    objMillPalletByCoilCellar.product = objMillPallet.ProductName;
                    objMillPalletByCoilCellar.siigoCellar = "0020";
                    objMillPalletByCoilCellar.siigoMovement = "S018";
                    objMillPalletByCoilCellar.bag = objMillPallet.bag;
                    objMillPalletByCoilCellar.ingress = false;
                    objMillPalletByCoilCellar.output = true;
                    objMillPalletByCoilCellar.devolution = false;
                    objMillPalletByCoilCellar.code = objMillPallet.code;
                    objMillPalletByCoilCellar.netweigth = objMillPallet.netWeigth;
                    objMillPalletByCoilCellar.grossweigth = objMillPallet.grossWeigth;
                    objMillPalletByCoilCellar.palletweigth = objMillPallet.palletWeigth;
                    objMillPalletByCoilCellar.order = objMillPallet.order;
                    objMillPalletByCoilCellar.customer = objMillPallet.customer;
                    objMillPalletByCoilCellar.movement = "Despacho ReProceso Calderón";
                    objMillPalletByCoilCellar.density = objMillPallet.density;
                    objMillPalletByCoilCellar.isImport = false;
                    return (objMillPalletByCoilCellar.save());
                }
                else if (rdbCustomer.Checked)
                {
                    objMillPallet.load(codsec);
                    objMillPalletByCoilCellar = new clsMillPalletbyCoilCellar();
                    objMillPalletByCoilCellar.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Molinos", "Despacho").codsec;
                    objMillPalletByCoilCellar.fkmillpallet = codsec;
                    objMillPalletByCoilCellar.product = objMillPallet.ProductName;
                    objMillPalletByCoilCellar.siigoCellar = "0020";
                    objMillPalletByCoilCellar.siigoMovement = "S020";
                    objMillPalletByCoilCellar.bag = objMillPallet.bag;
                    objMillPalletByCoilCellar.ingress = false;
                    objMillPalletByCoilCellar.output = true;
                    objMillPalletByCoilCellar.devolution = false;
                    objMillPalletByCoilCellar.code = objMillPallet.code;
                    objMillPalletByCoilCellar.netweigth = objMillPallet.netWeigth;
                    objMillPalletByCoilCellar.grossweigth = objMillPallet.grossWeigth;
                    objMillPalletByCoilCellar.palletweigth = objMillPallet.palletWeigth;
                    objMillPalletByCoilCellar.order = objMillPallet.order;
                    objMillPalletByCoilCellar.customer = objMillPallet.customer;
                    objMillPalletByCoilCellar.movement = "Despacho ReProceso Cliente";
                    objMillPalletByCoilCellar.density = objMillPallet.density;
                    objMillPalletByCoilCellar.isImport = false;
                    return (objMillPalletByCoilCellar.save());
                }
                else
                {
                    objMillPallet.load(codsec);
                    objMillPalletByCoilCellar = new clsMillPalletbyCoilCellar();
                    objMillPalletByCoilCellar.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Molinos", "Despacho").codsec;
                    objMillPalletByCoilCellar.fkmillpallet = codsec;
                    objMillPalletByCoilCellar.product = objMillPallet.ProductName;
                    objMillPalletByCoilCellar.siigoCellar = "0020";
                    objMillPalletByCoilCellar.siigoMovement = "H056";
                    objMillPalletByCoilCellar.bag = objMillPallet.bag;
                    objMillPalletByCoilCellar.ingress = false;
                    objMillPalletByCoilCellar.output = true;
                    objMillPalletByCoilCellar.devolution = false;
                    objMillPalletByCoilCellar.code = objMillPallet.code;
                    objMillPalletByCoilCellar.netweigth = objMillPallet.netWeigth;
                    objMillPalletByCoilCellar.grossweigth = objMillPallet.grossWeigth;
                    objMillPalletByCoilCellar.palletweigth = objMillPallet.palletWeigth;
                    objMillPalletByCoilCellar.order = objMillPallet.order;
                    objMillPalletByCoilCellar.customer = objMillPallet.customer;
                    objMillPalletByCoilCellar.movement = "Despacho ReProceso Guayaquil";
                    objMillPalletByCoilCellar.density = objMillPallet.density;
                    objMillPalletByCoilCellar.isImport = false;
                    return (objMillPalletByCoilCellar.save());
                }
            }
            else
                return false;
        }

        private class stctMyMill
        {
            public int number { get; set; }
            public int codsec { get; set; }
            public string code { get; set; }
            public string customer { get; set; }
            public string id { get; set; }
            public string product { get; set; }
            public double weightTotal { get; set; }
            public double grossTotal { get; set; }
            public double density { get; set; }
            public bool status { get; set; }
        }

        private void RealaodMill(List<stctMyMill> lstMyill)
        {
            dgvReprocess.Rows.Clear();
            for (int i = 0; i < lstMyill.Count; i++)
            {
                dgvReprocess.Rows.Add();
                dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocesscodsec.Index].Value = lstMyMill[i].codsec;
                dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocesspallet.Index].Value = 0;
                dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessnumber.Index].Value = (dgvReprocess.Rows.Count == 1) ? 1 : dgvReprocess.Rows.Count;
                dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocesscode.Index].Value = lstMyMill[i].code;
                dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocesscustomer.Index].Value = lstMyMill[i].customer;
                dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessproduct.Index].Value = lstMyMill[i].product;
                dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessid.Index].Value = lstMyMill[i].id;
                dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessnetweigth.Index].Value = lstMyMill[i].weightTotal;
                dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessgrossweigth.Index].Value = lstMyMill[i].grossTotal;
                dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessdensity.Index].Value = lstMyMill[i].density;
                dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocesscheck.Index].Value = global::BPS.Properties.Resources.check;
                dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessdelete.Index].Value = global::BPS.Properties.Resources.clear;
                dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessdestination.Index].Value = "Despachado";
                dgvReprocess.Rows[dgvReprocess.Rows.Count - 1].Cells[clmreprocessinfo.Index].Value = "OK";
            }
        }

        private void dgvReprocess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == clmreprocessdelete.Index)
                {
                    if (MessageBox.Show("Está realmente seguro que desea que desea eliminar el re-procesado seleccionada??", "Re - Procesado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    {
                        dgvReprocess.Rows.RemoveAt(e.RowIndex);
                        RefreshNumberMill();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Re - Procesado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void RefreshNumberMill()
        {
            for (int i = 0; i < dgvReprocess.Rows.Count; i++)
                dgvReprocess.Rows[i].Cells[clmreprocessnumber.Index].Value = (i + 1);
        }

        private void btnNewReProcess_Click(object sender, EventArgs e)
        {
            if (dgvReprocess.Rows.Count > 0)
            {
                if (MessageBox.Show("Existen datos en la grilla esta seguro que desea iniciar un nuevo despacho??", "Re - Procesado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    dgvReprocess.Rows.Clear();
                    txtReProcessCode.Text = string.Empty;
                    txtReProcessCode.Focus();
                    lstMyMill.Clear();
                }
            }
            else
            {
                if (MessageBox.Show("Esta por empezar un nuevo despacho desea continuar??", "Re - Procesado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    dgvReprocess.Rows.Clear();
                    txtReProcessCode.Text = string.Empty;
                    txtReProcessCode.Focus();
                }
            }
        }
    }
}
