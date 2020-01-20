using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmPalletMovement : Form
    {
        List<clsMaquile> lstMaquile = new List<clsMaquile>();
        string movementload = string.Empty;

        public frmPalletMovement()
        {
            InitializeComponent();
        }

        private void frmPalletMovement_Load(object sender, EventArgs e)
        {
            //Film
            grpbPalletCode.Enabled = false;
            grpbProduct.Enabled = false;
            grpbCustomer.Enabled = false;
            grpbWeigth.Enabled = false;
            grpbOrder.Enabled = false;
            grpbWith.Enabled = false;

            //Mill 
            grpbMillPallet.Enabled = false;
            grpbMillProduct.Enabled = false;
            grpbMillWeigth.Enabled = false;
            grpbMillOrder.Enabled = false;

            //raw
            gpbCodeRaw.Enabled = false;
            gpbLotRaw.Enabled = false;
            gpbProRaw.Enabled = false;
            grpbProveRaw.Enabled = false;
            grpbWeRaw.Enabled = false;
        }

        #region Filtros Pelicula

        private void chkbPalletCode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbPalletCode.Checked)
                grpbPalletCode.Enabled = true;
            else
                grpbPalletCode.Enabled = false;
        }

        private void chkbProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbProduct.Checked)
                grpbProduct.Enabled = true;
            else
                grpbProduct.Enabled = false;
        }

        private void chkbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbCustomer.Checked)
                grpbCustomer.Enabled = true;
            else
                grpbCustomer.Enabled = false;
        }

        private void chkbWeigth_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbWeigth.Checked)
                grpbWeigth.Enabled = true;
            else
                grpbWeigth.Enabled = false;
        }

        private void chkbOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbOrder.Checked)
                grpbOrder.Enabled = true;
            else
                grpbOrder.Enabled = false;
        }

        private void chkbWith_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbWith.Checked)
                grpbWith.Enabled = true;
            else
                grpbWith.Enabled = false;
        }

        private void txtPalletCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkbProduct.Checked || chkbCustomer.Checked || chkbWeigth.Checked || chkbOrder.Checked || chkbWith.Checked)
                    MessageBox.Show("Si desea utilizar múltiples filtros por favor de click en el botón de filtrado", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    FillDataByPalletCode(txtPalletCode.Text);
            }
        }

        private void FillDataByPalletCode(string palletcode)
        {
            List<clsPalletbyCoilCellar> lstPallet = new List<clsPalletbyCoilCellar>();
            lstPallet = clsPalletbyCoilCellar.getListTrabilityPallet(palletcode, true, string.Empty, false, string.Empty, false, 0, 0, false, string.Empty, false, 0, 0, false);
            if (lstPallet.Count > 0)
            {
                dgvPalletCellar.Rows.Clear();
                for (int i = 0; i < lstPallet.Count; i++)
                {
                    dgvPalletCellar.Rows.Add();
                    dgvPalletCellar.Rows[i].Cells[clmmovementcellar.Index].Value = lstPallet[i].movement;
                    dgvPalletCellar.Rows[i].Cells[clmmovementdate.Index].Value = lstPallet[i].date.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvPalletCellar.Rows[i].Cells[clmmovementcodepallet.Index].Value = lstPallet[i].code;
                    dgvPalletCellar.Rows[i].Cells[clmmovementproduct.Index].Value = lstPallet[i].producto;
                    dgvPalletCellar.Rows[i].Cells[clmmovementpalletcomposition.Index].Value = lstPallet[i].palletnumber + " - " + lstPallet[i].coilnumber;
                    dgvPalletCellar.Rows[i].Cells[clmmovementcustomer.Index].Value = lstPallet[i].customer;
                    dgvPalletCellar.Rows[i].Cells[clmmovementorder.Index].Value = lstPallet[i].order;
                    dgvPalletCellar.Rows[i].Cells[clmmovementwith.Index].Value = lstPallet[i].width;
                    dgvPalletCellar.Rows[i].Cells[clmmovementweigth.Index].Value = lstPallet[i].netweigth;
                }

                colorateByCoilCellar();
            }
            else
            {
                dgvPalletCellar.Rows.Clear();
                MessageBox.Show("No existen coincidencias con ese pallet por favor ingrese uno pallet válido", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPalletCode.Focus();
            }
        }

        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkbPalletCode.Checked || chkbCustomer.Checked || chkbWeigth.Checked || chkbOrder.Checked || chkbWith.Checked)
                    MessageBox.Show("Si desea utilizar multiples filtros por favor de click en el botón de filtrado", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    FillDataByProduct(txtProduct.Text);
            }
        }

        private void FillDataByProduct(String product)
        {
            List<clsPalletbyCoilCellar> lstPallet = new List<clsPalletbyCoilCellar>();
            lstPallet = clsPalletbyCoilCellar.getListTrabilityPallet(string.Empty, false, product, true, string.Empty, false, 0, 0, false, string.Empty, false, 0, 0, false);
            if (lstPallet.Count > 0)
            {
                dgvPalletCellar.Rows.Clear();
                for (int i = 0; i < lstPallet.Count; i++)
                {
                    dgvPalletCellar.Rows.Add();
                    dgvPalletCellar.Rows[i].Cells[clmmovementcellar.Index].Value = lstPallet[i].movement;
                    dgvPalletCellar.Rows[i].Cells[clmmovementdate.Index].Value = lstPallet[i].date.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvPalletCellar.Rows[i].Cells[clmmovementcodepallet.Index].Value = lstPallet[i].code;
                    dgvPalletCellar.Rows[i].Cells[clmmovementproduct.Index].Value = lstPallet[i].producto;
                    dgvPalletCellar.Rows[i].Cells[clmmovementpalletcomposition.Index].Value = lstPallet[i].palletnumber + " - " + lstPallet[i].coilnumber;
                    dgvPalletCellar.Rows[i].Cells[clmmovementcustomer.Index].Value = lstPallet[i].customer;
                    dgvPalletCellar.Rows[i].Cells[clmmovementorder.Index].Value = lstPallet[i].order;
                    dgvPalletCellar.Rows[i].Cells[clmmovementwith.Index].Value = lstPallet[i].width;
                    dgvPalletCellar.Rows[i].Cells[clmmovementweigth.Index].Value = lstPallet[i].netweigth;
                }
                colorateByCoilCellar();
            }
            else
            {
                dgvPalletCellar.Rows.Clear();
                MessageBox.Show("No existen coincidencias con ese producto por favor ingrese uno producto válido", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProduct.Focus();
            }
        }

        private void txtCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkbPalletCode.Checked || chkbProduct.Checked || chkbWeigth.Checked || chkbOrder.Checked || chkbWith.Checked)
                    MessageBox.Show("Si desea utilizar multiples filtros por favor de click en el botón de filtrado", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    FillDataByCustomer(txtCustomer.Text);
            }
        }

        private void FillDataByCustomer(string customer)
        {
            List<clsPalletbyCoilCellar> lstPallet = new List<clsPalletbyCoilCellar>();
            lstPallet = clsPalletbyCoilCellar.getListTrabilityPallet(string.Empty, false, string.Empty, false, customer, true, 0, 0, false, string.Empty, false, 0, 0, false);
            if (lstPallet.Count > 0)
            {
                dgvPalletCellar.Rows.Clear();
                for (int i = 0; i < lstPallet.Count; i++)
                {
                    dgvPalletCellar.Rows.Add();
                    dgvPalletCellar.Rows[i].Cells[clmmovementcellar.Index].Value = lstPallet[i].movement;
                    dgvPalletCellar.Rows[i].Cells[clmmovementdate.Index].Value = lstPallet[i].date.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvPalletCellar.Rows[i].Cells[clmmovementcodepallet.Index].Value = lstPallet[i].code;
                    dgvPalletCellar.Rows[i].Cells[clmmovementproduct.Index].Value = lstPallet[i].producto;
                    dgvPalletCellar.Rows[i].Cells[clmmovementpalletcomposition.Index].Value = lstPallet[i].palletnumber + " - " + lstPallet[i].coilnumber;
                    dgvPalletCellar.Rows[i].Cells[clmmovementcustomer.Index].Value = lstPallet[i].customer;
                    dgvPalletCellar.Rows[i].Cells[clmmovementorder.Index].Value = lstPallet[i].order;
                    dgvPalletCellar.Rows[i].Cells[clmmovementwith.Index].Value = lstPallet[i].width;
                    dgvPalletCellar.Rows[i].Cells[clmmovementweigth.Index].Value = lstPallet[i].netweigth;
                }
                colorateByCoilCellar();
            }
            else
            {
                dgvPalletCellar.Rows.Clear();
                MessageBox.Show("No existen coincidencias con ese cliente por favor ingrese un cliente válido", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomer.Focus();
            }
        }

        private void txtInitWeigth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkbPalletCode.Checked || chkbProduct.Checked || chkbCustomer.Checked || chkbOrder.Checked || chkbWith.Checked)
                    MessageBox.Show("Si desea utilizar multiples filtros por favor de click en el botón de filtrado", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (txtInitWeigth.Text != string.Empty && txtEndWeigth.Text == string.Empty)
                        FillDataByWeigth(Convert.ToDouble(txtInitWeigth.Text), 0);
                    else if (Convert.ToDouble(txtEndWeigth.Text) < Convert.ToDouble(txtInitWeigth.Text))
                    {
                        MessageBox.Show("El peso fin no puede ser menor que el peso inicio por favor vuelva a ingresar los datos", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtInitWeigth.Focus();
                        txtInitWeigth.Clear();
                        txtInitWeigth.ForeColor = Color.Black;
                    }
                    else if (txtInitWeigth.Text == string.Empty && txtEndWeigth.Text == string.Empty)
                        MessageBox.Show("Debe ingresar por lo menos un valor", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        FillDataByWeigth(Convert.ToDouble(txtInitWeigth.Text), Convert.ToDouble(txtEndWeigth.Text));
                }
            }
        }

        private void FillDataByWeigth(double initweigth, double endweigth)
        {
            List<clsPalletbyCoilCellar> lstPallet = new List<clsPalletbyCoilCellar>();
            lstPallet = clsPalletbyCoilCellar.getListTrabilityPallet(string.Empty, false, string.Empty, false, string.Empty, false, initweigth, endweigth, true, string.Empty, false, 0, 0, false);
            if (lstPallet.Count > 0)
            {
                dgvPalletCellar.Rows.Clear();
                for (int i = 0; i < lstPallet.Count; i++)
                {
                    dgvPalletCellar.Rows.Add();
                    dgvPalletCellar.Rows[i].Cells[clmmovementcellar.Index].Value = lstPallet[i].movement;
                    dgvPalletCellar.Rows[i].Cells[clmmovementdate.Index].Value = lstPallet[i].date.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvPalletCellar.Rows[i].Cells[clmmovementcodepallet.Index].Value = lstPallet[i].code;
                    dgvPalletCellar.Rows[i].Cells[clmmovementproduct.Index].Value = lstPallet[i].producto;
                    dgvPalletCellar.Rows[i].Cells[clmmovementpalletcomposition.Index].Value = lstPallet[i].palletnumber + " - " + lstPallet[i].coilnumber;
                    dgvPalletCellar.Rows[i].Cells[clmmovementcustomer.Index].Value = lstPallet[i].customer;
                    dgvPalletCellar.Rows[i].Cells[clmmovementorder.Index].Value = lstPallet[i].order;
                    dgvPalletCellar.Rows[i].Cells[clmmovementwith.Index].Value = lstPallet[i].width;
                    dgvPalletCellar.Rows[i].Cells[clmmovementweigth.Index].Value = lstPallet[i].netweigth;
                }
                colorateByCoilCellar();
            }
            else
            {
                dgvPalletCellar.Rows.Clear();
                MessageBox.Show("No existen coincidencias con ese peso por favor ingrese un peso válido", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInitWeigth.Focus();
            }
        }

        private void txtEndWeigth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkbPalletCode.Checked || chkbProduct.Checked || chkbCustomer.Checked || chkbOrder.Checked || chkbWith.Checked)
                    MessageBox.Show("Si desea utilizar multiples filtros por favor de click en el botón de filtrado", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (txtInitWeigth.Text == string.Empty && txtEndWeigth.Text != string.Empty)
                    {
                        MessageBox.Show("Debe ingresar un valor en peso inicio", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtInitWeigth.Focus();
                        txtInitWeigth.Clear();
                        txtInitWeigth.ForeColor = Color.Black;
                    }
                    else if (txtInitWeigth.Text != string.Empty && txtEndWeigth.Text == string.Empty)
                        FillDataByWeigth(Convert.ToDouble(txtInitWeigth.Text), 0);
                    else if (Convert.ToDouble(txtEndWeigth.Text) < Convert.ToDouble(txtInitWeigth.Text))
                    {
                        MessageBox.Show("El peso fin no puede ser menor que el peso inicio por favor vuelva a ingresar los datos", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtInitWeigth.Focus();
                        txtInitWeigth.Clear();
                        txtInitWeigth.ForeColor = Color.Black;
                    }
                    else if (txtInitWeigth.Text == string.Empty && txtEndWeigth.Text == string.Empty)
                        MessageBox.Show("Debe ingresar por lo menos un valor", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        FillDataByWeigth(Convert.ToDouble(txtInitWeigth.Text), Convert.ToDouble(txtEndWeigth.Text));
                }
            }
        }

        private void txtOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkbPalletCode.Checked || chkbProduct.Checked || chkbCustomer.Checked || chkbWeigth.Checked || chkbWith.Checked)
                    MessageBox.Show("Si desea utilizar multiples filtros por favor de click en el botón de filtrado", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    FillDataByOrder(txtOrder.Text);
            }
        }

        private void FillDataByOrder(string order)
        {
            List<clsPalletbyCoilCellar> lstPallet = new List<clsPalletbyCoilCellar>();
            lstPallet = clsPalletbyCoilCellar.getListTrabilityPallet(string.Empty, false, string.Empty, false, string.Empty, false, 0, 0, false, order, true, 0, 0, false);
            if (lstPallet.Count > 0)
            {
                dgvPalletCellar.Rows.Clear();
                for (int i = 0; i < lstPallet.Count; i++)
                {
                    dgvPalletCellar.Rows.Add();
                    dgvPalletCellar.Rows[i].Cells[clmmovementcellar.Index].Value = lstPallet[i].movement;
                    dgvPalletCellar.Rows[i].Cells[clmmovementdate.Index].Value = lstPallet[i].date.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvPalletCellar.Rows[i].Cells[clmmovementcodepallet.Index].Value = lstPallet[i].code;
                    dgvPalletCellar.Rows[i].Cells[clmmovementproduct.Index].Value = lstPallet[i].producto;
                    dgvPalletCellar.Rows[i].Cells[clmmovementpalletcomposition.Index].Value = lstPallet[i].palletnumber + " - " + lstPallet[i].coilnumber;
                    dgvPalletCellar.Rows[i].Cells[clmmovementcustomer.Index].Value = lstPallet[i].customer;
                    dgvPalletCellar.Rows[i].Cells[clmmovementorder.Index].Value = lstPallet[i].order;
                    dgvPalletCellar.Rows[i].Cells[clmmovementwith.Index].Value = lstPallet[i].width;
                    dgvPalletCellar.Rows[i].Cells[clmmovementweigth.Index].Value = lstPallet[i].netweigth;
                }
                colorateByCoilCellar();
            }
            else
            {
                dgvPalletCellar.Rows.Clear();
                MessageBox.Show("No existen coincidencias con esa orden por favor ingrese una orden válida", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOrder.Focus();
            }
        }

        private void txtInitWith_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkbPalletCode.Checked || chkbProduct.Checked || chkbCustomer.Checked || chkbOrder.Checked || chkbWeigth.Checked)
                    MessageBox.Show("Si desea utilizar multiples filtros por favor de click en el botón de filtrado", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (txtInitWith.Text != string.Empty && txtEndWith.Text == string.Empty)
                        FillDataByWith(Convert.ToInt32(txtInitWith.Text), 0);
                    else if (Convert.ToDouble(txtEndWith.Text) < Convert.ToDouble(txtInitWith.Text))
                    {
                        MessageBox.Show("El ancho fin no puede ser menor que el ancho inicio por favor vuelva a ingresar los datos", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtInitWith.Focus();
                        txtInitWith.Clear();
                        txtInitWith.ForeColor = Color.Black;
                    }
                    else if (txtInitWith.Text == string.Empty && txtEndWith.Text == string.Empty)
                        MessageBox.Show("Debe ingresar por lo menos un valor", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        FillDataByWith(Convert.ToInt32(txtInitWith.Text), Convert.ToInt32(txtEndWith.Text));
                }
            }
        }

        private void FillDataByWith(int initwidth, int endwtih)
        {
            List<clsPalletbyCoilCellar> lstPallet = new List<clsPalletbyCoilCellar>();
            lstPallet = clsPalletbyCoilCellar.getListTrabilityPallet(string.Empty, false, string.Empty, false, string.Empty, false, 0, 0, false, string.Empty, false, initwidth, endwtih, true);
            if (lstPallet.Count > 0)
            {
                dgvPalletCellar.Rows.Clear();
                for (int i = 0; i < lstPallet.Count; i++)
                {
                    dgvPalletCellar.Rows.Add();
                    dgvPalletCellar.Rows[i].Cells[clmmovementcellar.Index].Value = lstPallet[i].movement;
                    dgvPalletCellar.Rows[i].Cells[clmmovementdate.Index].Value = lstPallet[i].date.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvPalletCellar.Rows[i].Cells[clmmovementcodepallet.Index].Value = lstPallet[i].code;
                    dgvPalletCellar.Rows[i].Cells[clmmovementproduct.Index].Value = lstPallet[i].producto;
                    dgvPalletCellar.Rows[i].Cells[clmmovementpalletcomposition.Index].Value = lstPallet[i].palletnumber + " - " + lstPallet[i].coilnumber;
                    dgvPalletCellar.Rows[i].Cells[clmmovementcustomer.Index].Value = lstPallet[i].customer;
                    dgvPalletCellar.Rows[i].Cells[clmmovementorder.Index].Value = lstPallet[i].order;
                    dgvPalletCellar.Rows[i].Cells[clmmovementwith.Index].Value = lstPallet[i].width;
                    dgvPalletCellar.Rows[i].Cells[clmmovementweigth.Index].Value = lstPallet[i].netweigth;
                }
                colorateByCoilCellar();
            }
            else
            {
                dgvPalletCellar.Rows.Clear();
                MessageBox.Show("No existen coincidencias con ese ancho por favor ingrese un ancho válido", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInitWeigth.Focus();
            }
        }

        private void txtEndWith_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkbPalletCode.Checked || chkbProduct.Checked || chkbCustomer.Checked || chkbOrder.Checked || chkbWeigth.Checked)
                    MessageBox.Show("Si desea utilizar multiples filtros por favor de click en el botón de filtrado", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (txtInitWith.Text == string.Empty && txtEndWith.Text != string.Empty)
                    {
                        MessageBox.Show("Debe ingresar un valor en ancho inicio", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtInitWith.Focus();
                        txtInitWith.Clear();
                        txtInitWith.ForeColor = Color.Black;
                    }
                    else if (Convert.ToDouble(txtEndWith.Text) < Convert.ToDouble(txtInitWith.Text))
                    {
                        MessageBox.Show("El ancho fin no puede ser menor que el ancho inicio por favor vuelva a ingresar los datos", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtInitWith.Focus();
                        txtInitWith.Clear();
                        txtInitWith.ForeColor = Color.Black;
                    }
                    else if (txtInitWith.Text == string.Empty && txtEndWith.Text == string.Empty)
                        MessageBox.Show("Debe ingresar por lo menos un valor", "Trazabilidad Palet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        FillDataByWith(Convert.ToInt32(txtInitWith.Text), Convert.ToInt32(txtEndWith.Text));
                }
            }
        }

        private void txtInitWeigth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtEndWeigth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnClerFilter_Click(object sender, EventArgs e)
        {
            grpbPalletCode.Enabled = false;
            grpbProduct.Enabled = false;
            grpbCustomer.Enabled = false;
            grpbWeigth.Enabled = false;
            grpbOrder.Enabled = false;
            grpbWith.Enabled = false;
            txtCustomer.Clear();
            txtEndWeigth.Clear();
            txtEndWith.Clear();
            txtInitWeigth.Clear();
            txtInitWith.Clear();
            txtOrder.Clear();
            txtPalletCode.Clear();
            txtProduct.Clear();
            chkbCustomer.Checked = false;
            chkbOrder.Checked = false;
            chkbPalletCode.Checked = false;
            chkbProduct.Checked = false;
            chkbWeigth.Checked = false;
            chkbWith.Checked = false;
            dgvPalletCellar.Rows.Clear();
        }

        public void colorateByCoilCellar()
        {
            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                if (dgvPalletCellar.Rows[i].Cells[clmmovementcellar.Index].Value != null)
                {
                    switch (dgvPalletCellar.Rows[i].Cells[clmmovementcellar.Index].Value.ToString())
                    {
                        case "Despacho de mercadería":
                            for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
                                dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(207, 234, 254);
                            break;
                        case "Salida a bodega de proceso":
                            for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
                                dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
                            break;
                        case "Salida a bodega de base para metalizar":
                            for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
                                dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(176, 247, 182);
                            break;
                        case "Ingreso a bodega de producto terminado":
                            for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
                                dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(188, 188, 254);
                            break;
                        case "Ingreso a bodega de stock local":
                            for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
                                dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(177, 211, 185);
                            break;
                        //case "Bajas":
                        //    for (int j = 0; j < dgvDetails.Columns.Count; j++)
                        //        dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(249, 196, 183);
                        //    break;
                        //case "Stock Perú":
                        //    for (int j = 0; j < dgvDetails.Columns.Count; j++)
                        //        dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(247, 202, 153);
                        //    break;
                        //case "Base para metalizar":
                        //    for (int j = 0; j < dgvDetails.Columns.Count; j++)
                        //        dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(241, 218, 239);
                        default:
                            break;
                    }
                }
            }
        }
        #endregion

        #region Filtros RePro
        private void chkMillPallet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMillPallet.Checked)
                grpbMillPallet.Enabled = true;
            else
                grpbMillPallet.Enabled = false;
        }

        private void chkMillProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMillProduct.Checked)
                grpbMillProduct.Enabled = true;
            else
                grpbMillProduct.Enabled = false;
        }

        private void chkMillWeigth_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMillWeigth.Checked)
                grpbMillWeigth.Enabled = true;
            else
                grpbMillWeigth.Enabled = false;
        }

        private void chkMillOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMillOrder.Checked)
                grpbMillOrder.Enabled = true;
            else
                grpbMillOrder.Enabled = false;
        }

        private void txtMillCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkMillProduct.Checked || chkMillWeigth.Checked || chkMillOrder.Checked)
                    MessageBox.Show("Usted no puede usar filtros múltiples", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                else
                    FillDataMillCode(txtMillCode.Text);
            }
        }

        private void FillDataMillCode(string code)
        {
            List<clsMillPalletbyCoilCellar> lstPallet = new List<clsMillPalletbyCoilCellar>();
            lstPallet = clsMillPalletbyCoilCellar.getMillListTrazabilityCode(code.ToUpper());
            if (lstPallet.Count > 0)
            {
                dgvMillPallet.Rows.Clear();
                for (int i = 0; i < lstPallet.Count; i++)
                {
                    dgvMillPallet.Rows.Add();
                    dgvMillPallet.Rows[i].Cells[clmmillcodsec.Index].Value = lstPallet[i].codsec;
                    dgvMillPallet.Rows[i].Cells[clmmillmovement.Index].Value = lstPallet[i].movement;
                    dgvMillPallet.Rows[i].Cells[clmmilldate.Index].Value = lstPallet[i].date.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvMillPallet.Rows[i].Cells[clmmillcode.Index].Value = lstPallet[i].code;
                    dgvMillPallet.Rows[i].Cells[clmmillproduct.Index].Value = lstPallet[i].product;
                    dgvMillPallet.Rows[i].Cells[clmmillpalletweigth.Index].Value = Math.Round(lstPallet[i].palletweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillgrossweigth.Index].Value = Math.Round(lstPallet[i].grossweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillnetweigth.Index].Value = Math.Round(lstPallet[i].netweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillorder.Index].Value = lstPallet[i].order;
                }
                colorateByMillCellar();
            }
            else
            {
                dgvMillPallet.Rows.Clear();
                MessageBox.Show("No existen coincidencias con ese pallet por favor ingrese uno pallet válido", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMillCode.Focus();
            }
        }

        private void txtMillProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkMillPallet.Checked || chkMillWeigth.Checked || chkMillOrder.Checked)
                    MessageBox.Show("Usted no puede usar filtros múltiples", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                else
                    FillDataMillProduct(txtMillProduct.Text);
            }
        }

        private void FillDataMillProduct(string product)
        {
            List<clsMillPalletbyCoilCellar> lstPallet = new List<clsMillPalletbyCoilCellar>();
            lstPallet = clsMillPalletbyCoilCellar.getMillListTrazabilityProduct(product);
            if (lstPallet.Count > 0)
            {
                dgvMillPallet.Rows.Clear();
                for (int i = 0; i < lstPallet.Count; i++)
                {
                    dgvMillPallet.Rows.Add();
                    dgvMillPallet.Rows[i].Cells[clmmillcodsec.Index].Value = lstPallet[i].codsec;
                    dgvMillPallet.Rows[i].Cells[clmmillmovement.Index].Value = lstPallet[i].movement;
                    dgvMillPallet.Rows[i].Cells[clmmilldate.Index].Value = lstPallet[i].date.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvMillPallet.Rows[i].Cells[clmmillcode.Index].Value = lstPallet[i].code;
                    dgvMillPallet.Rows[i].Cells[clmmillproduct.Index].Value = lstPallet[i].product;
                    dgvMillPallet.Rows[i].Cells[clmmillpalletweigth.Index].Value = Math.Round(lstPallet[i].palletweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillgrossweigth.Index].Value = Math.Round(lstPallet[i].grossweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillnetweigth.Index].Value = Math.Round(lstPallet[i].netweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillorder.Index].Value = lstPallet[i].order;
                }

                colorateByMillCellar();
            }
            else
            {
                dgvMillPallet.Rows.Clear();
                MessageBox.Show("No existen coincidencias con ese pallet por favor ingrese uno pallet válido", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMillCode.Focus();
            }
        }

        private void txtMillOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkMillPallet.Checked || chkMillWeigth.Checked || chkMillProduct.Checked)
                    MessageBox.Show("Usted no puede usar filtros múltiples", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                else
                    FillDataMillOrder(txtMillOrder.Text);
            }
        }

        private void FillDataMillOrder(string order)
        {
            List<clsMillPalletbyCoilCellar> lstPallet = new List<clsMillPalletbyCoilCellar>();
            lstPallet = clsMillPalletbyCoilCellar.getMillListTrazabilityOrder(order);
            if (lstPallet.Count > 0)
            {
                dgvMillPallet.Rows.Clear();
                for (int i = 0; i < lstPallet.Count; i++)
                {
                    dgvMillPallet.Rows.Add();
                    dgvMillPallet.Rows[i].Cells[clmmillcodsec.Index].Value = lstPallet[i].codsec;
                    dgvMillPallet.Rows[i].Cells[clmmillmovement.Index].Value = lstPallet[i].movement;
                    dgvMillPallet.Rows[i].Cells[clmmilldate.Index].Value = lstPallet[i].date.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvMillPallet.Rows[i].Cells[clmmillcode.Index].Value = lstPallet[i].code;
                    dgvMillPallet.Rows[i].Cells[clmmillproduct.Index].Value = lstPallet[i].product;
                    dgvMillPallet.Rows[i].Cells[clmmillpalletweigth.Index].Value = Math.Round(lstPallet[i].palletweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillgrossweigth.Index].Value = Math.Round(lstPallet[i].grossweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillnetweigth.Index].Value = Math.Round(lstPallet[i].netweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillorder.Index].Value = lstPallet[i].order;
                }
                colorateByMillCellar();
            }
            else
            {
                dgvMillPallet.Rows.Clear();
                MessageBox.Show("No existen coincidencias con ese pallet por favor ingrese uno pallet válido", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMillCode.Focus();
            }
        }

        private void txtMillFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtMillTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtMillFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkMillPallet.Checked || chkMillOrder.Checked || chkMillProduct.Checked)
                    MessageBox.Show("Usted no puede usar filtros múltiples", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                else
                {
                    if (txtMillTo.Text.Length <= 0 && txtMillFrom.Text.Length > 0)
                        FillDataMillFrom(Convert.ToDouble(txtMillFrom.Text));
                    else if (txtMillTo.Text.Length > 0 && txtMillFrom.Text.Length > 0)
                        FillDataMillFromTo(Convert.ToDouble(txtMillFrom.Text), Convert.ToDouble(txtMillTo.Text));
                }
            }
        }

        private void FillDataMillFromTo(double weigthFrom, double weigthTo)
        {
            List<clsMillPalletbyCoilCellar> lstPallet = new List<clsMillPalletbyCoilCellar>();
            lstPallet = clsMillPalletbyCoilCellar.getMillListWeigthFromTo(weigthFrom, weigthTo);
            if (lstPallet.Count > 0)
            {
                dgvMillPallet.Rows.Clear();
                for (int i = 0; i < lstPallet.Count; i++)
                {
                    dgvMillPallet.Rows.Add();
                    dgvMillPallet.Rows[i].Cells[clmmillcodsec.Index].Value = lstPallet[i].codsec;
                    dgvMillPallet.Rows[i].Cells[clmmillmovement.Index].Value = lstPallet[i].movement;
                    dgvMillPallet.Rows[i].Cells[clmmilldate.Index].Value = lstPallet[i].date.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvMillPallet.Rows[i].Cells[clmmillcode.Index].Value = lstPallet[i].code;
                    dgvMillPallet.Rows[i].Cells[clmmillproduct.Index].Value = lstPallet[i].product;
                    dgvMillPallet.Rows[i].Cells[clmmillpalletweigth.Index].Value = Math.Round(lstPallet[i].palletweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillgrossweigth.Index].Value = Math.Round(lstPallet[i].grossweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillnetweigth.Index].Value = Math.Round(lstPallet[i].netweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillorder.Index].Value = lstPallet[i].order;
                }
                colorateByMillCellar();
            }
            else
            {
                dgvMillPallet.Rows.Clear();
                MessageBox.Show("No existen coincidencias con ese pallet por favor ingrese uno pallet válido", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMillCode.Focus();
            }
        }

        private void FillDataMillFrom(double weigthFrom)
        {
            List<clsMillPalletbyCoilCellar> lstPallet = new List<clsMillPalletbyCoilCellar>();
            lstPallet = clsMillPalletbyCoilCellar.getMillListWeigthFrom(weigthFrom);
            if (lstPallet.Count > 0)
            {
                dgvMillPallet.Rows.Clear();
                for (int i = 0; i < lstPallet.Count; i++)
                {
                    dgvMillPallet.Rows.Add();
                    dgvMillPallet.Rows[i].Cells[clmmillcodsec.Index].Value = lstPallet[i].codsec;
                    dgvMillPallet.Rows[i].Cells[clmmillmovement.Index].Value = lstPallet[i].movement;
                    dgvMillPallet.Rows[i].Cells[clmmilldate.Index].Value = lstPallet[i].date.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvMillPallet.Rows[i].Cells[clmmillcode.Index].Value = lstPallet[i].code;
                    dgvMillPallet.Rows[i].Cells[clmmillproduct.Index].Value = lstPallet[i].product;
                    dgvMillPallet.Rows[i].Cells[clmmillpalletweigth.Index].Value = Math.Round(lstPallet[i].palletweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillgrossweigth.Index].Value = Math.Round(lstPallet[i].grossweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillnetweigth.Index].Value = Math.Round(lstPallet[i].netweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillorder.Index].Value = lstPallet[i].order;
                }
                colorateByMillCellar();
            }
            else
            {
                dgvMillPallet.Rows.Clear();
                MessageBox.Show("No existen coincidencias con ese pallet por favor ingrese uno pallet válido", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMillCode.Focus();
            }
        }

        private void txtMillTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (chkMillPallet.Checked || chkMillOrder.Checked || chkMillProduct.Checked)
                    MessageBox.Show("Usted no puede usar filtros múltiples", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                else
                {
                    if (txtMillFrom.Text.Length <= 0 && txtMillTo.Text.Length > 0)
                        FillDataMillTo(Convert.ToDouble(txtMillTo.Text));
                    else if (txtMillTo.Text.Length > 0 && txtMillFrom.Text.Length > 0)
                        FillDataMillFromTo(Convert.ToDouble(txtMillFrom.Text), Convert.ToDouble(txtMillTo.Text));
                }
            }
        }

        private void FillDataMillTo(double weigthTo)
        {
            List<clsMillPalletbyCoilCellar> lstPallet = new List<clsMillPalletbyCoilCellar>();
            lstPallet = clsMillPalletbyCoilCellar.getMillListWeigthTo(weigthTo);
            if (lstPallet.Count > 0)
            {
                dgvMillPallet.Rows.Clear();
                for (int i = 0; i < lstPallet.Count; i++)
                {
                    dgvMillPallet.Rows.Add();
                    dgvMillPallet.Rows[i].Cells[clmmillcodsec.Index].Value = lstPallet[i].codsec;
                    dgvMillPallet.Rows[i].Cells[clmmillmovement.Index].Value = lstPallet[i].movement;
                    dgvMillPallet.Rows[i].Cells[clmmilldate.Index].Value = lstPallet[i].date.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvMillPallet.Rows[i].Cells[clmmillcode.Index].Value = lstPallet[i].code;
                    dgvMillPallet.Rows[i].Cells[clmmillproduct.Index].Value = lstPallet[i].product;
                    dgvMillPallet.Rows[i].Cells[clmmillpalletweigth.Index].Value = Math.Round(lstPallet[i].palletweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillgrossweigth.Index].Value = Math.Round(lstPallet[i].grossweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillnetweigth.Index].Value = Math.Round(lstPallet[i].netweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMillPallet.Rows[i].Cells[clmmillorder.Index].Value = lstPallet[i].order;
                }
                colorateByMillCellar();
            }
            else
            {
                dgvMillPallet.Rows.Clear();
                MessageBox.Show("No existen coincidencias con ese pallet por favor ingrese uno pallet válido", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMillCode.Focus();
            }
        }

        private void colorateByMillCellar()
        {
            for (int i = 0; i < dgvMillPallet.Rows.Count; i++)
            {
                if (dgvMillPallet.Rows[i].Cells[clmmillmovement.Index].Value != null)
                {
                    switch (dgvMillPallet.Rows[i].Cells[clmmillmovement.Index].Value.ToString())
                    {
                        case "Ingreso de Produccion Molinos":
                            for (int j = 0; j < dgvMillPallet.Columns.Count; j++)
                                dgvMillPallet.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(207, 234, 254);
                            break;
                        case "Salida a Planta DMT":
                            for (int j = 0; j < dgvMillPallet.Columns.Count; j++)
                                dgvMillPallet.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
                            break;
                        case "Salida a Planta MW":
                            for (int j = 0; j < dgvMillPallet.Columns.Count; j++)
                                dgvMillPallet.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(176, 247, 182);
                            break;
                        case "Despacho ReProceso Cliente":
                            for (int j = 0; j < dgvMillPallet.Columns.Count; j++)
                                dgvMillPallet.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(188, 188, 254);
                            break;
                        case "Despacho ReProceso Calderón":
                            for (int j = 0; j < dgvMillPallet.Columns.Count; j++)
                                dgvMillPallet.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(177, 211, 185);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMillCode.Clear();
            txtMillProduct.Clear();
            txtMillFrom.Clear();
            txtMillOrder.Clear();
            txtMillTo.Clear();
            chkMillOrder.Enabled = false;
            chkMillPallet.Enabled = false;
            chkMillProduct.Enabled = false;
            chkMillWeigth.Enabled = false;
        }
        #endregion

        #region Maquile
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (cmbMovements.SelectedIndex > -1)
            {
                if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) < 0)
                {
                    movementload = cmbMovements.Text.ToString();
                    PopulateMaquile(dtpInitDate.Value, dtpEndDate.Value, movementload);
                }
                else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) == 0)
                    MessageBox.Show("Las fechas no pueden ser iguales por favor cambie las fechas", "Exportación de Maquilas al Siigo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) > 0)
                    MessageBox.Show("La fecha inicio no pueden ser mayor que la fecha fin", "Exportación de Maquilas al Siigo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un movimiento antes de poder visualizar los datos", "Exportación de Maquilas al Siigo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                cmbMovements.SelectedText = string.Empty;
                cmbMovements.Focus();
            }
        }

        private void PopulateMaquile(DateTime dtpInitDate, DateTime dtpEndDate, string movementload)
        {
            lstMaquile = clsMaquile.getListMovementByDate(dtpInitDate, dtpEndDate, movementload);
            if (lstMaquile.Count > 0)
            {
                dgvMaquile.Rows.Clear();
                for (int i = 0; i < lstMaquile.Count; i++)
                {
                    dgvMaquile.Rows.Add();
                    dgvMaquile.Rows[i].Cells[clmmaquilecodsec.Index].Value = lstMaquile[i].codsec;
                    dgvMaquile.Rows[i].Cells[clmmaquilemovement.Index].Value = lstMaquile[i].movementcellar;
                    dgvMaquile.Rows[i].Cells[clmmaquiledate.Index].Value = lstMaquile[i].createdDate.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvMaquile.Rows[i].Cells[clmmaquilecode.Index].Value = lstMaquile[i].notes;
                    dgvMaquile.Rows[i].Cells[clmmaquileproduct.Index].Value = lstMaquile[i].product;
                    dgvMaquile.Rows[i].Cells[clmmaquilepalletcoil.Index].Value = lstMaquile[i].pallet + "-" + lstMaquile[i].coil;
                    dgvMaquile.Rows[i].Cells[clmmaquilewidth.Index].Value = lstMaquile[i].width;
                    dgvMaquile.Rows[i].Cells[clmmaquileweigth.Index].Value = Math.Round(lstMaquile[i].weigth, 1, MidpointRounding.AwayFromZero).ToString();
                    dgvMaquile.Rows[i].Cells[clmmaquileprinty.Index].Value = global::BPS.Properties.Resources.printer;
                }
            }
            else
            {
                dgvMaquile.Rows.Clear();
                MessageBox.Show("No existen coincidencias con ese pallet por favor ingrese uno pallet válido", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvMaquile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmmaquileprinty.Index)
            {
                if (MessageBox.Show("Esta seguro que desea imprimir el reporte?\r\nRecuerde que debe tener como mínimo una impresora determinada..", "Devoluciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    if (Convert.ToInt32(dgvMaquile.Rows[e.RowIndex].Cells[clmmaquilecodsec.Index].Value) != 0)
                        clsPrintLabels.printMaquileLabel(Convert.ToInt32(dgvMaquile.Rows[e.RowIndex].Cells[clmmaquilecodsec.Index].Value));
                }
            }
        }
        #endregion

        #region Raw
        private void chkPltRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPltRaw.Checked)
                gpbCodeRaw.Enabled = true;
            else
                gpbCodeRaw.Enabled = false;
        }

        private void chkProRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProRaw.Checked)
                gpbProRaw.Enabled = true;
            else
                gpbProRaw.Enabled = false;
        }

        private void chkLotRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLotRaw.Checked)
                gpbLotRaw.Enabled = true;
            else
                gpbLotRaw.Enabled = false;
        }

        private void chkProveeRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProveeRaw.Checked)
                grpbProveRaw.Enabled = true;
            else
                grpbProveRaw.Enabled = false;
        }

        private void chkbWeRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbWeRaw.Checked)
                grpbWeRaw.Enabled = true;
            else
                grpbWeRaw.Enabled = false;
        }

        private void txtpalletRaw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtpalletRaw.Text))
                    ProcessRaw("code", txtpalletRaw.Text, "");
                else
                    MessageBox.Show("Al menos debe ingresar un valor");
            }
        }

        private void txtproRaw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtproRaw.Text))
                    ProcessRaw("product", txtproRaw.Text, "");
                else
                    MessageBox.Show("Al menos debe ingresar un valor");
            }
        }

        private void txtlotRaw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtlotRaw.Text))
                    ProcessRaw("lot", txtlotRaw.Text, "");
                else
                    MessageBox.Show("Al menos debe ingresar un valor");
            }
        }

        private void txtprovRaw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtprovRaw.Text))
                    ProcessRaw("provider", txtprovRaw.Text, "");
                else
                    MessageBox.Show("Al menos debe ingresar un valor");
            }
        }

        private void txtw1Raw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtw1Raw.Text))
                    ProcessRaw("w1", txtw1Raw.Text, "");
                else
                    MessageBox.Show("Al menos debe ingresar un valor");
            }
        }

        private void txtw2Raw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtw2Raw.Text))
                {
                    if (!string.IsNullOrEmpty(txtw1Raw.Text))
                        ProcessRaw("w2", txtw1Raw.Text, txtw2Raw.Text);
                    else
                        ProcessRaw("w1", txtw1Raw.Text, "");
                }
                else
                    MessageBox.Show("Al menos debe ingresar un valor");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtw1Raw.Clear();
            txtw2Raw.Clear();
            txtlotRaw.Clear();
            txtprovRaw.Clear();
            txtproRaw.Clear();
            txtpalletRaw.Clear();
            chkPltRaw.Enabled = false;
            chkProRaw.Enabled = false;
            chkProveeRaw.Enabled = false;
            chkLotRaw.Enabled = false;
            chkbWeRaw.Enabled = false;
        }

        private void ProcessRaw(string source, string value1, string value2)
        {
            var rawList = clsRawMaterialbyCoilCellar.getFilterList(source, value1, value2);

            if (rawList.Count > 0)
            {
                dgvRaw.Rows.Clear();

                for (int i = 0; i < rawList.Count; i++)
                {
                    dgvRaw.Rows.Add();
                    dgvRaw.Rows[i].Cells[clmrmovement.Index].Value = rawList[i].movement;
                    dgvRaw.Rows[i].Cells[clmrdate.Index].Value = rawList[i].date.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvRaw.Rows[i].Cells[clmrcode.Index].Value = rawList[i].code;
                    dgvRaw.Rows[i].Cells[clmrpro.Index].Value = rawList[i].product;
                    dgvRaw.Rows[i].Cells[clmrprove.Index].Value = rawList[i].provider;
                    dgvRaw.Rows[i].Cells[clmrlot.Index].Value = rawList[i].lotnumber;
                    dgvRaw.Rows[i].Cells[clmrweigth.Index].Value = rawList[i].netweigth;
                    dgvRaw.Rows[i].Cells[clmrcellar.Index].Value = rawList[i].siigoCellar;
                    dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value = rawList[i].siigoMovement;
                }
                colorRaw();
            }
            else
            {
                dgvRaw.Rows.Clear();
                MessageBox.Show("No existen coincidencias", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtInitWeigth.Focus();
            }
        }

        private void colorRaw()
        {
            for (int i = 0; i < dgvRaw.Rows.Count; i++)
            {
                if (dgvRaw.Rows[i].Cells[clmrcellar.Index].Value != null)
                {
                    switch (dgvRaw.Rows[i].Cells[clmrcellar.Index].Value.ToString())
                    {
                        case "001":

                            if (dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value.ToString() == "E004" || dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value.ToString() == "E005" ||
                                dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value.ToString() == "E002" || dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value.ToString() == "E035" ||
                                dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value.ToString() == "E030")
                            {
                                for (int j = 0; j < dgvRaw.Columns.Count; j++)
                                    dgvRaw.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(207, 234, 254);
                            }
                            else if (dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value.ToString() == "H016" || dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value.ToString() == "H004" ||
                                dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value.ToString() == "H018" || dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value.ToString() == "H017" ||
                                dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value.ToString() == "H005")
                            {
                                for (int j = 0; j < dgvRaw.Columns.Count; j++)
                                    dgvRaw.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(176, 247, 182);
                            }
                            else
                            {
                                for (int j = 0; j < dgvRaw.Columns.Count; j++)
                                    dgvRaw.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(188, 188, 254);
                            }

                            break;

                        case "004":

                            if (dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value.ToString() == "E031" || dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value.ToString() == "E033" ||
                                dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value.ToString() == "E036")
                            {
                                for (int j = 0; j < dgvRaw.Columns.Count; j++)
                                    dgvRaw.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
                            }
                            else if (dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value.ToString() == "H001" || dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value.ToString() == "H003" ||
                                dgvRaw.Rows[i].Cells[clmrmsiigo.Index].Value.ToString() == "H007")
                            {
                                for (int j = 0; j < dgvRaw.Columns.Count; j++)
                                    dgvRaw.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(176, 247, 182);
                            }
                            else
                            {
                                for (int j = 0; j < dgvRaw.Columns.Count; j++)
                                    dgvRaw.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(188, 188, 254);
                            }

                            break;

                        default:
                            break;
                    }
                }
            }
        }

        #endregion












        //private void btnFilter_Click(object sender, EventArgs e)
        //{
        //    FillDataByFilter(chkbPalletCode.Checked, chkbProduct.Checked, chkbCustomer.Checked, chkbWeigth.Checked, chkbOrder.Checked, chkbWith.Checked);



        //    //if (chkbPalletCode.Checked && chkbProduct.Checked && chkbCustomer.Checked && chkbOrder.Checked && chkbWeigth.Checked && chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Todos");
        //    //}
        //    //else if (chkbPalletCode.Checked && !chkbProduct.Checked && !chkbCustomer.Checked && !chkbOrder.Checked && !chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Pallet Coode");
        //    //}
        //    //else if (!chkbPalletCode.Checked && chkbProduct.Checked && !chkbCustomer.Checked && !chkbOrder.Checked && !chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Product");
        //    //}
        //    //else if (!chkbPalletCode.Checked && !chkbProduct.Checked && chkbCustomer.Checked && !chkbOrder.Checked && !chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Customer");
        //    //}
        //    //else if (!chkbPalletCode.Checked && !chkbProduct.Checked && !chkbCustomer.Checked && chkbOrder.Checked && !chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Order");
        //    //}
        //    //else if (chkbPalletCode.Checked && !chkbProduct.Checked && !chkbCustomer.Checked && !chkbOrder.Checked && chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Weigth");
        //    //}
        //    //else if (chkbPalletCode.Checked && !chkbProduct.Checked && !chkbCustomer.Checked && !chkbOrder.Checked && !chkbWeigth.Checked && chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Width");
        //    //}
        //    //else if (chkbPalletCode.Checked && chkbProduct.Checked && !chkbCustomer.Checked && !chkbOrder.Checked && !chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Pallet Coode - Product");
        //    //}
        //    //else if (chkbPalletCode.Checked && !chkbProduct.Checked && chkbCustomer.Checked && !chkbOrder.Checked && !chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Pallet Coode -  Customer");
        //    //}
        //    //else if (chkbPalletCode.Checked && !chkbProduct.Checked && !chkbCustomer.Checked && chkbOrder.Checked && !chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Pallet Coode - Order");
        //    //}
        //    //else if (chkbPalletCode.Checked && !chkbProduct.Checked && !chkbCustomer.Checked && !chkbOrder.Checked && chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Pallet Coode -  Weigth");
        //    //}
        //    //else if (chkbPalletCode.Checked && !chkbProduct.Checked && !chkbCustomer.Checked && !chkbOrder.Checked && !chkbWeigth.Checked && chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Pallet Coode - Width");
        //    //}
        //    //else if (!chkbPalletCode.Checked && chkbProduct.Checked && chkbCustomer.Checked && !chkbOrder.Checked && !chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Product - Customer");
        //    //}
        //    //else if (!chkbPalletCode.Checked && chkbProduct.Checked && !chkbCustomer.Checked && chkbOrder.Checked && !chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Product - Order");
        //    //}
        //    //else if (!chkbPalletCode.Checked && chkbProduct.Checked && !chkbCustomer.Checked && !chkbOrder.Checked && chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Product -  Weigth");
        //    //}
        //    //else if (!chkbPalletCode.Checked && chkbProduct.Checked && !chkbCustomer.Checked && chkbOrder.Checked && !chkbWeigth.Checked && chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Product - Width");
        //    //}
        //    //else if (!chkbPalletCode.Checked && !chkbProduct.Checked && chkbCustomer.Checked && chkbOrder.Checked && !chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Customer -  Order");
        //    //}
        //    //else if (!chkbPalletCode.Checked && !chkbProduct.Checked && chkbCustomer.Checked && !chkbOrder.Checked && chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Customer - Weigth");
        //    //}
        //    //else if (!chkbPalletCode.Checked && !chkbProduct.Checked && chkbCustomer.Checked && !chkbOrder.Checked && !chkbWeigth.Checked && chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Customer - Width");
        //    //}
        //    //else if (!chkbPalletCode.Checked && !chkbProduct.Checked && !chkbCustomer.Checked && chkbOrder.Checked && chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Order - Weigth");
        //    //}
        //    //else if (!chkbPalletCode.Checked && !chkbProduct.Checked && !chkbCustomer.Checked && chkbOrder.Checked && !chkbWeigth.Checked && chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Order - Width");
        //    //}
        //    //else if (!chkbPalletCode.Checked && !chkbProduct.Checked && !chkbCustomer.Checked && !chkbOrder.Checked && chkbWeigth.Checked && chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Weigth - Width");
        //    //}
        //    //else if (chkbPalletCode.Checked && chkbProduct.Checked && chkbCustomer.Checked && !chkbOrder.Checked && !chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Pallet Coode - Product - Customer");
        //    //}
        //    //else if (chkbPalletCode.Checked && chkbProduct.Checked && chkbCustomer.Checked && chkbOrder.Checked && !chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Pallet Coode - Product - Customer - Order");
        //    //}
        //    //else if (chkbPalletCode.Checked && chkbProduct.Checked && chkbCustomer.Checked && chkbOrder.Checked && chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Pallet Coode - Product - Customer - Order - Weigth");
        //    //}
        //    //else if (!chkbPalletCode.Checked && chkbProduct.Checked && chkbCustomer.Checked && chkbOrder.Checked && !chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Product - Customer - Order");
        //    //}
        //    //else if (!chkbPalletCode.Checked && chkbProduct.Checked && chkbCustomer.Checked && chkbOrder.Checked && chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Product - Customer - Order - Weigth");
        //    //}
        //    //else if (!chkbPalletCode.Checked && chkbProduct.Checked && chkbCustomer.Checked && chkbOrder.Checked && chkbWeigth.Checked && chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Product - Customer - Order - Weigth - Width");
        //    //}
        //    //else if (!chkbPalletCode.Checked && !chkbProduct.Checked && chkbCustomer.Checked && chkbOrder.Checked && chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Customer - Order - Weigth");
        //    //}
        //    //else if (!chkbPalletCode.Checked && !chkbProduct.Checked && chkbCustomer.Checked && chkbOrder.Checked && chkbWeigth.Checked && chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Customer - Order - Weigth - Width");
        //    //}
        //    //else if (chkbPalletCode.Checked && !chkbProduct.Checked && chkbCustomer.Checked && !chkbOrder.Checked && !chkbWeigth.Checked && !chkbWith.Checked)
        //    //{
        //    //    MessageBox.Show("Pallet Coode -  Customer");
        //    //}
        //}

        //private void FillDataByFilter(bool palletcode, bool product, bool customer, bool weigth, bool order, bool width)
        //{
        //    if (palletcode && product && !customer && !weigth && !order && !width)
        //        MessageBox.Show("Pallet -  product");
        //    else if (palletcode && !product && customer && !weigth && !order && !width)
        //        MessageBox.Show("Pallet - customer");
        //    else if (palletcode && !product && !customer && weigth && !order && !width)
        //        MessageBox.Show("Pallet - weigth");
        //    else if (palletcode && !product && !customer && !weigth && order && !width)
        //        MessageBox.Show("Pallet - order");
        //    else if (palletcode && !product && !customer && !weigth && !order && width)
        //        MessageBox.Show("Pallet - width");
        //    else if (!palletcode && product && customer && !weigth && !order && !width)
        //        MessageBox.Show("Product - customer");
        //    else if (!palletcode && product && !customer && weigth && !order && !width)
        //        MessageBox.Show("Product - weigth");
        //    else if (!palletcode && product && !customer && !weigth && order && !width)
        //        MessageBox.Show("Product - order");
        //    else if (!palletcode && product && !customer && !weigth && !order && width)
        //        MessageBox.Show("Product - width");
        //    else if (!palletcode && !product && customer && weigth && !order && !width)
        //        MessageBox.Show("Customer - weigth");
        //    else if (!palletcode && !product && customer && !weigth && order && !width)
        //        MessageBox.Show("Customer - order");
        //    else if (!palletcode && !product && customer && !weigth && !order && width)
        //        MessageBox.Show("Customer - width");
        //    else if (!palletcode && !product && !customer && weigth && order && width)
        //        MessageBox.Show("Weigth - order");
        //    else if (!palletcode && product && customer && !weigth && order && width)
        //        MessageBox.Show("Customer - order");
        //    else if (!palletcode && product && !customer && !weigth && order && width)
        //        MessageBox.Show("Order - width");
        //    else if (palletcode && product && customer && !weigth && !order && !width)
        //        MessageBox.Show("Pallet - customer - product");
        //    else if (palletcode && product && customer && weigth && !order && !width)
        //        MessageBox.Show("Pallet - customer - product - weigth");
        //    else if (palletcode && product && customer && weigth && order && !width)
        //        MessageBox.Show("Pallet - customer - product - weigth - order");
        //    else if (palletcode && product && customer && weigth && order && width)
        //        MessageBox.Show("Pallet - customer - product - weigth - order - width");
        //    else if (!palletcode && product && customer && weigth && !order && !width)
        //        MessageBox.Show("Product - customer - weigth");
        //    else if (!palletcode && product && customer && weigth && order && !width)
        //        MessageBox.Show("Product - customer - weigth - order");
        //    else if (!palletcode && product && customer && weigth && order && width)
        //        MessageBox.Show("Product - customer - weigth - order - width");
        //    else if (!palletcode && !product && customer && weigth && order && !width)
        //        MessageBox.Show("Customer - weigth - order");
        //    else if (!palletcode && !product && customer && weigth && order && width)
        //        MessageBox.Show("Customer - weigth - order - width");
        //    else if (!palletcode && !product && !customer && weigth && order && width)
        //        MessageBox.Show("Weigth - order - width");
        //}
    }
}
