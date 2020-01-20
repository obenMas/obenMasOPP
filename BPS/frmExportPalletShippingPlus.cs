using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using System.Threading;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmExportPalletShippingPlus : Form
    {
        List<clsPalletbyCoilCellar> lstPallet = new List<clsPalletbyCoilCellar>();
        List<clsPalletbyCoilCellar> lstPalletAux = new List<clsPalletbyCoilCellar>();
        bool executeFilter = true;
        delegate void showLoading();
        delegate void HideLoading();
        string movementload = string.Empty;
        public DateTime dtpEndMonth = DateTime.Now;
        private bool isActiveCalendar = false;

        showLoading showLoadImage;
        HideLoading hideLoadImage;

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstPallet = clsPalletbyCoilCellar.getListMovementByDateShipping(dtpInitDate.Value, dtpEndDate.Value);
            this.Invoke(hideLoadImage);
        }

        private void showLoadingDelegate()
        {
            groupBox4.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;
            pbxLoading.Visible = true;
            pbxLoading.Enabled = true;
            lblLoading.Visible = true;
        }

        public frmExportPalletShippingPlus()
        {
            InitializeComponent();
            getPalletList();
        }

        private void hideLoadingDelegate()
        {
            groupBox2.BringToFront();

            fillPalletInfo();

            List<string> lstProducts = new List<string>();
            List<string> lstCustomers = new List<string>();
            List<string> lstSalesOrderNumber = new List<string>();
            List<string> lstMovemenet = new List<string>();

            for (int i = 0; i < lstPallet.Count; i++)
            {
                //Products
                bool flgIsProductInList = false;
                for (int j = 0; j < lstProducts.Count; j++)
                {
                    if (lstPallet[i].ObjProduct.boppCode != "")
                    {
                        if (lstProducts[j] == lstPallet[i].ObjProduct.boppCode.Replace("-",""))
                        {
                            flgIsProductInList = true;
                            break;
                        }
                    }
                    else
                    {
                        if (lstProducts[j] == lstPallet[i].ObjProduct.castCode.Replace("-",""))
                        {
                            flgIsProductInList = true;
                            break;
                        }
                    }
                }

                if (flgIsProductInList == false)
                    lstProducts.Add((lstPallet[i].ObjProduct.boppCode.Replace("-", "") == "") ? lstPallet[i].ObjProduct.castCode.Replace("-", "") : lstPallet[i].ObjProduct.boppCode.Replace("-", ""));

                //Customers
                bool flgIsCustomerInList = false;
                for (int j = 0; j < lstCustomers.Count; j++)
                {
                    if (lstCustomers[j] == lstPallet[i].customer)
                    {
                        flgIsCustomerInList = true;
                        break;
                    }
                }
                if (flgIsCustomerInList == false)
                    lstCustomers.Add(lstPallet[i].customer);


                //Sales Order Number
                bool flgIsSalesOrderNumberInList = false;
                for (int j = 0; j < lstSalesOrderNumber.Count; j++)
                {
                    if (lstSalesOrderNumber[j] == lstPallet[i].order)
                    {
                        flgIsSalesOrderNumberInList = true;
                        break;
                    }
                }
                if (flgIsSalesOrderNumberInList == false)
                    lstSalesOrderNumber.Add(lstPallet[i].order);

                //Movement
                bool flgIsMovement = false;
                for (int j = 0; j < lstMovemenet.Count; j++)
                {
                    if (lstMovemenet[j] == lstPallet[i].siigoMovement)
                    {
                        flgIsMovement = true;
                        break;
                    }
                }
                if (flgIsMovement == false)
                    lstMovemenet.Add(lstPallet[i].siigoMovement);

            }

            lstProducts.Sort();
            lstCustomers.Sort();
            lstSalesOrderNumber.Sort();
            lstMovemenet.Sort();

            for (int i = 0; i < lstProducts.Count; i++)
                cmbProduct.Items.Add(lstProducts[i]);

            for (int i = 0; i < lstCustomers.Count; i++)
                cmbCustomer.Items.Add(lstCustomers[i]);

            for (int i = 0; i < lstSalesOrderNumber.Count; i++)
                cmbOrder.Items.Add(lstSalesOrderNumber[i]);

            for (int i = 0; i < lstMovemenet.Count; i++)
                cmbMovement.Items.Add(lstMovemenet[i]);

            colorateByOrigin();
            groupBox4.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }

        private void fillPalletInfo()
        {
            double cellar3 = 0;
            double cellar23 = 0;
            double cellar18 = 0;

            if (executeFilter == true)
            {
                dgvPalletCellar.Rows.Clear();

                for (int i = 0; i < lstPallet.Count; i++)
                {
                    bool flgInclude = false;
                    bool flgOKFilm = false;
                    bool flgOKCustomer = false;
                    bool flgOKSalesOrder = false;
                    bool flgOkMovement = false;

                    if (cmbProduct.Text != "" || cmbCustomer.Text != "" || cmbOrder.Text != "" || cmbProduct.SelectedIndex > -1 || cmbCustomer.SelectedIndex > -1 || cmbOrder.SelectedIndex > -1 || cmbMovement.Text != "" || cmbMovement.SelectedIndex > -1)
                    {
                        //Film
                        if (cmbProduct.SelectedIndex > -1 || cmbProduct.Text != "")
                        {

                            if (lstPallet[i].ObjProduct.boppCode != "")
                            {
                                if (lstPallet[i].ObjProduct.boppCode.Replace("-","").ToUpper().StartsWith(cmbProduct.Text.ToString().ToUpper()))
                                    flgOKFilm = true;
                            }
                            else
                            {
                                if (lstPallet[i].ObjProduct.castCode.Replace("-", "").ToUpper().StartsWith(cmbProduct.Text.ToString().ToUpper()))
                                    flgOKFilm = true;
                            }

                            if (lstPallet[i].ObjProduct.boppCode.ToUpper().StartsWith(cmbProduct.Text.ToString().ToUpper()))
                                flgOKFilm = true;
                        }

                        if (cmbProduct.Text == "" && cmbProduct.SelectedIndex == -1)
                            flgOKFilm = true;

                        //Customer
                        if (cmbCustomer.SelectedIndex > -1 || cmbCustomer.Text != "")
                        {
                            if (lstPallet[i].customer.ToUpper().StartsWith(cmbCustomer.Text.ToString().ToUpper()))
                                flgOKCustomer = true;
                        }

                        if (cmbCustomer.Text == "" && cmbCustomer.SelectedIndex == -1)
                            flgOKCustomer = true;

                        //Sales Order
                        if (cmbOrder.Text != "" || cmbOrder.SelectedIndex > -1)
                        {
                            if (lstPallet[i].order.StartsWith(cmbOrder.Text))
                                flgOKSalesOrder = true;
                        }

                        if (cmbOrder.Text == "" && cmbOrder.SelectedIndex == -1)
                            flgOKSalesOrder = true;


                        //Movement
                        if (cmbMovement.Text != "" || cmbMovement.SelectedIndex > -1)
                        {
                            if (lstPallet[i].siigoMovement == cmbMovement.Text)
                                flgOkMovement = true;
                        }

                        if (cmbMovement.Text == "" && cmbMovement.SelectedIndex == -1)
                            flgOkMovement = true;

                        if (flgOKFilm == true && flgOKCustomer == true && flgOKSalesOrder == true && flgOkMovement == true)
                            flgInclude = true;
                    }
                    else
                        flgInclude = true;


                    if (flgInclude == true)
                    {
                        dgvPalletCellar.Rows.Add();
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobencodsec.Index].Value = lstPallet[i].codsec;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobennumber.Index].Value = (dgvPalletCellar.Rows.Count - 1) + 1;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocellar.Index].Value = lstPallet[i].siigoCellar;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigomovement.Index].Value = lstPallet[i].siigoMovement;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocode.Index].Value = lstPallet[i].siigoCode;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigoreference.Index].Value = lstPallet[i].siigoReference;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenorigin.Index].Value = lstPallet[i].origin;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenbopp.Index].Value = lstPallet[i].localweigth;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenopp.Index].Value = lstPallet[i].oppweigth;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenweigth.Index].Value = lstPallet[i].netweigth;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenproduct.Index].Value = lstPallet[i].producto;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenmovement.Index].Value = lstPallet[i].movement;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobencustomer.Index].Value = lstPallet[i].customer;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenorder.Index].Value = lstPallet[i].order;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenwidth.Index].Value = lstPallet[i].width;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenpb.Index].Value = lstPallet[i].palletnumber + "-" + lstPallet[i].coilnumber;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobendate.Index].Value = lstPallet[i].date.ToShortDateString();
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmfilter.Index].Value = global::BPS.Properties.Resources.clear;
                        if (dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocellar.Index].Value.ToString() == "3")
                            cellar3 += Math.Round(Convert.ToDouble(dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenweigth.Index].Value), 1);
                        else if (dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocellar.Index].Value.ToString() == "23")
                            cellar23 += Math.Round(Convert.ToDouble(dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenweigth.Index].Value), 1);
                        else if (dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocellar.Index].Value.ToString() == "18")
                            cellar18 += Math.Round(Convert.ToDouble(dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenweigth.Index].Value), 1);
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenvalidate.Index].Value = "0";
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenvalidatevalue.Index].Value = 0;
                        //dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocellar.Index].Value = clsXportCellarMovementsToSIIGO.exportCellar(lstPalletAux).Replace("0", "");
                        //dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigomovement.Index].Value = clsXportCellarMovementsToSIIGO.movementCellar(lstPalletAux);
                        //dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocode.Index].Value = clsXportCellarMovementsToSIIGO.codeCellar(lstPalletAux);
                        //dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigoreference.Index].Value = clsXportCellarMovementsToSIIGO.ReferenceCellar(dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocode.Index].Value.ToString());
                        
                    }
                }
            }
            colorateByOrigin();
            lblTCellar3.Text = cellar3.ToString();
            lblTCellar23.Text = cellar23.ToString();
            lblTCellar18.Text = cellar18.ToString();
        }

        private void frmExportPalletMovementPlus_Load(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) < 0)
                {
                    movementload = string.Empty;
                    ClearMyFilter();
                    Thread td = new Thread(new ThreadStart(this.loadMovements));
                    td.Start();
                }
                else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) == 0)
                    MessageBox.Show("Las fechas no pueden ser iguales por favor cambie las fechas", "Exportación de Movimientos al Siigo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) > 0)
                    MessageBox.Show("La fecha inicio no pueden ser mayor que la fecha fin", "Exportación de Movimientos al Siigo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exportación de Movimientos al Siigo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        public void colorateByOrigin()
        {
            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                if (dgvPalletCellar.Rows[i].Cells[clmobenorigin.Index].Value != null)
                {
                    switch (dgvPalletCellar.Rows[i].Cells[clmobenorigin.Index].Value.ToString())
                    {
                        case "BOPP":
                            if (dgvPalletCellar.Rows[i].Cells[clmobencustomer.Index].Value.ToString() == "STOCK")
                            {
                                for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
                                    dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(249, 203, 202);
                            }
                            else
                            {
                                for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
                                    dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(218, 232, 137);
                            }
                            break;
                        
                        case "OPP":
                            for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
                                dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(230, 95, 0);

                            break;

                        case "MIXTO":
                            for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
                                dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(176, 247, 182);
                            break;

                        case "-----":
                            for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
                                dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(188, 188, 254);
                            break;

                        default:
                            break;
                    }
                }
            }
        }
    
        private void ClearMyFilter()
        {
            cmbCellar.Text = string.Empty;
            cmbCustomer.Text = string.Empty;
            cmbMovement.Text = string.Empty;
            cmbOrder.Text = string.Empty;
            cmbProduct.Text = string.Empty;
            dgvPalletCellar.Rows.Clear();
            cmbCellar.Items.Clear();
            cmbCustomer.Items.Clear();
            cmbMovement.Items.Clear();
            cmbOrder.Items.Clear();
            cmbProduct.Items.Clear();
            lblnumber.Text = "0";
        }

        private void getPalletList()
        {
            showLoadImage = new showLoading(showLoadingDelegate);
            hideLoadImage = new HideLoading(hideLoadingDelegate);
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex > -1)
                fillPalletInfo();
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex > -1)
                fillPalletInfo();
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrder.SelectedIndex > -1)
                fillPalletInfo();
        }

        private void cmbMovement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMovement.SelectedIndex > -1)
                fillPalletInfo();
        }

        private void cmbCellar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCellar.SelectedIndex > -1)
                fillPalletInfo();
        }

        private void cmbProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbMovement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbCellar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void dgvPalletCellar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmfilter.Index)
            {
                if (dgvPalletCellar.Rows[e.RowIndex].Cells[clmobenvalidatevalue.Index].Value.ToString() != "0")
                {
                    dgvPalletCellar.Rows[e.RowIndex].Cells[clmfilter.Index].Value = global::BPS.Properties.Resources.clear;
                    dgvPalletCellar.Rows[e.RowIndex].Cells[clmobenvalidatevalue.Index].Value = 0;
                }
                else
                {
                    dgvPalletCellar.Rows[e.RowIndex].Cells[clmfilter.Index].Value = global::BPS.Properties.Resources.accept;
                    dgvPalletCellar.Rows[e.RowIndex].Cells[clmobenvalidatevalue.Index].Value = 1;
                }
            }
        }

        private void dgvPalletCellar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmsiigocode.Index)
            {
                if (e.RowIndex > -1)
                {
                    frmXtraFilmEquivalence winXtraFilmEquivalence = new frmXtraFilmEquivalence(dgvPalletCellar.Rows[e.RowIndex].Cells[clmobenproduct.Index].Value.ToString());
                    winXtraFilmEquivalence.ShowDialog();
                }
            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked == true)
            {
                for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                {
                    dgvPalletCellar.Rows[i].Cells[clmfilter.Index].Value = global::BPS.Properties.Resources.accept;
                    dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value = 1;
                    dgvPalletCellar.FirstDisplayedScrollingRowIndex = i;
                }
            }
            else
            {
                if (MessageBox.Show("Esta realmente seguro que desea eliminar la selección de los pallets?", "Exportación de Movimientos al Siigo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.OK)
                {
                    for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                    {
                        dgvPalletCellar.Rows[i].Cells[clmfilter.Index].Value = global::BPS.Properties.Resources.clear;
                        dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value = 0;
                        dgvPalletCellar.FirstDisplayedScrollingRowIndex = i;
                    }
                    chkSelectAll.Checked = false;
                }
            }
        }

        private void btnFilterPallet_Click(object sender, EventArgs e)
        {
            double cellar3 = 0;
            double cellar23 = 0;
            double cellar18 = 0;

            bool hasSelectedRows = false;

            List<clsPalletbyCoilCellar> lstPalletMovement = new List<clsPalletbyCoilCellar>();

            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "1")
                    hasSelectedRows = true;
            }
            if (hasSelectedRows == true)
            {
                if (MessageBox.Show("Los registros no seleccionados serán eliminados del listado para no ser tomados en cuenta en la exportación. Desea continuar?", "Exportación de movimientos a SIIGO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    var count = 0;

                    List<int> lstPos = new List<int>();

                    for (int i = dgvPalletCellar.Rows.Count - 1; i >= 0; i--)
                    {
                        if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "0")
                            lstPos.Add(i);
                        else
                        {
                            count++;
                            lblnumber.Text = count.ToString();
                        }
                    }

                    for (int i = 0; i < lstPos.Count; i++)
                        dgvPalletCellar.Rows.RemoveAt(lstPos[i]);

                    for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                    {
                        if (dgvPalletCellar.Rows[i].Cells[clmsiigocellar.Index].Value.ToString() == "3")
                            cellar3 += Math.Round(Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmobenweigth.Index].Value), 1);
                        else if (dgvPalletCellar.Rows[i].Cells[clmsiigocellar.Index].Value.ToString() == "23")
                            cellar23 += Math.Round(Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmobenweigth.Index].Value), 1);
                        else if (dgvPalletCellar.Rows[i].Cells[clmsiigocellar.Index].Value.ToString() == "18")
                            cellar18 += Math.Round(Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmobenweigth.Index].Value), 1);
                    }

                    dgvPalletCellar.Sort(clmobenorder, ListSortDirection.Ascending);
                    lblTCellar3.Text = cellar3.ToString();
                    lblTCellar23.Text = cellar23.ToString();
                    lblTCellar18.Text = cellar18.ToString();
                }

            }
            else
                MessageBox.Show("No ha seleccionado ninguna orden de venta para ser exportada.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                clsProduct objProduct = new clsProduct(dgvPalletCellar.Rows[i].Cells[clmobenproduct.Index].Value.ToString());
                objProduct = new clsProduct(objProduct.codsec);
                bool flgIsValidated = true;

                if (objProduct.Bopp.codsec != 0)
                {
                    if (Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmobenbopp.Index].Value) > 0 && Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmobenopp.Index].Value) == 0)
                    {
                        if (dgvPalletCellar.Rows[i].Cells[clmobencustomer.Index].Value.ToString() == "STOCK")
                        {
                            if (clsProduct.getExternalERPDescriptionStockCode(objProduct) == "")
                                flgIsValidated = false;
                        }
                        else
                        {
                            if (clsProduct.getExternalERPDescriptionNationalCode(objProduct) == "")
                                flgIsValidated = false;
                        }
                    }
                    else if (Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmobenbopp.Index].Value) == 0 && Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmobenopp.Index].Value) > 0)
                    {
                        if (clsProduct.getExternalERPDescriptionExternalCode(objProduct) == "")
                            flgIsValidated = false;
                    }
                    else if (Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmobenbopp.Index].Value) > 0 && Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmobenopp.Index].Value) > 0)
                    {
                        if (clsProduct.getExternalERPDescriptionExternalCode(objProduct) == "" || clsProduct.getExternalERPDescriptionNationalCode(objProduct) == "")
                            flgIsValidated = false;
                    }
                }

                if (objProduct.Cast.codsec != 0)
                {
                    if (clsProduct.getExternalERPDescriptionExternalCode(objProduct) == "")
                        flgIsValidated = false;
                }

                if (flgIsValidated == true)
                {
                    dgvPalletCellar.Rows[i].Cells[clmobenproduct.Index].Style.ForeColor = Color.Black;
                    dgvPalletCellar.Rows[i].Cells[clmobenproduct.Index].Style.SelectionForeColor = Color.Black;
                    dgvPalletCellar.Rows[i].Cells[clmsiigocode.Index].Style.ForeColor = Color.Black;
                    dgvPalletCellar.Rows[i].Cells[clmsiigocode.Index].Style.SelectionForeColor = Color.Black;
                    dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value = 1;
                }
                else
                {
                    dgvPalletCellar.Rows[i].Cells[clmobenproduct.Index].Style.ForeColor = Color.Red;
                    dgvPalletCellar.Rows[i].Cells[clmobenproduct.Index].Style.SelectionForeColor = Color.Red;
                    dgvPalletCellar.Rows[i].Cells[clmsiigocode.Index].Style.ForeColor = Color.Red;
                    dgvPalletCellar.Rows[i].Cells[clmsiigocode.Index].Style.SelectionForeColor = Color.Red;
                    dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value = 0;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            bool hasSelectedRows = false;
            List<clsPalletbyCoilCellar> lstPalletMovement = new List<clsPalletbyCoilCellar>();

            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "1")
                    hasSelectedRows = true;
            }
            if (hasSelectedRows == true)
            {
                bool hasInvalidRows = true;
                for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                {
                    if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "0")
                        hasInvalidRows = false;
                }
                if (hasInvalidRows == true)
                {

                    if (MessageBox.Show("Se realizará el proceso de creación de los archivos de exportación a SIIGO de los movimientos seleccionados.\n\n Desea continuar?", "Exportación de movimientos a SIIGO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        string folderPath = "";
                        fbdFilePath.Description = "Por favor, seleccione la ubicación donde se guardarán los archivos de exportación.";
                        fbdFilePath.ShowDialog();

                        folderPath = fbdFilePath.SelectedPath;
                        lstPalletMovement = new List<clsPalletbyCoilCellar>();

                        for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                        {
                            if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "1")
                            {
                                lstPalletMovement.Add(new clsPalletbyCoilCellar(Convert.ToInt32(dgvPalletCellar.Rows[i].Cells[clmobencodsec.Index].Value), true));
                                lstPalletMovement[i].codsec = Convert.ToInt32(dgvPalletCellar.Rows[i].Cells[clmobencodsec.Index].Value);
                                lstPalletMovement[i].siigoCellar = dgvPalletCellar.Rows[i].Cells[clmsiigocellar.Index].Value.ToString();
                                lstPalletMovement[i].siigoMovement = dgvPalletCellar.Rows[i].Cells[clmsiigomovement.Index].Value.ToString();
                                lstPalletMovement[i].siigoCode = dgvPalletCellar.Rows[i].Cells[clmsiigocode.Index].Value.ToString();
                                lstPalletMovement[i].siigoReference = dgvPalletCellar.Rows[i].Cells[clmsiigoreference.Index].Value.ToString();
                            }
                        }

                        if (clsXportCellarMovementsToSIIGO.exportCellarShippingPalletToSiigo(lstPalletMovement, folderPath, 1, isActiveCalendar, dtpEndMonth))
                        {
                            MessageBox.Show("Se han generado los archivos para la exportación de las ordenes de venta al SIIGO con éxito.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            ClearMyFilter();
                        }
                        else
                            MessageBox.Show("Ha habido un problema al generar los archivos de exportación, por favor comuníquese con el administrador.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
                else
                    MessageBox.Show("Hay películas que no han sido validadas por no tener su correspondiente código de siigo, revise estos códigos para continuar.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            else
                MessageBox.Show("No ha seleccionado ninguna orden de venta para ser exportada.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            isActiveCalendar = true;
            frmCalendar winCalendar = new frmCalendar(this);
            winCalendar.ShowDialog(this);
            if (dtpEndMonth.Date == DateTime.Now.Date)
                isActiveCalendar = false;
            else
                isActiveCalendar = true;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            bool hasSelectedRows = false;

            List<string> lstString = new List<string>();

            string myList = string.Empty;

            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "1")
                    hasSelectedRows = true;
            }

            if (hasSelectedRows == true)
            {
                frmCalendar winCalendar = new frmCalendar(this);
                winCalendar.ShowDialog(this);
                if (dtpEndMonth.Date == DateTime.Now.Date)
                    isActiveCalendar = false;
                else
                    isActiveCalendar = true;

                for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                {
                    if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "1")
                    {
                        myList += dgvPalletCellar.Rows[i].Cells[clmobencodsec.Index].Value.ToString();
                        myList += ((i < dgvPalletCellar.Rows.Count - 1) ? ";" : "");
                    }
                }
                frmPalletByCoilCellarReport winPallet = new frmPalletByCoilCellarReport(myList, dtpEndMonth.Date, cmbMovement.Text);
                winPallet.ShowDialog(this);
            }
            else
                MessageBox.Show("No ha seleccionado ninguna orden de venta para generar el reporte de movimientos.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        }

        private void btnRar_Click(object sender, EventArgs e)
        {
            bool hasSelectedRows = false;
            List<clsPalletbyCoilCellar> lstPalletMovement = new List<clsPalletbyCoilCellar>();

            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "1")
                    hasSelectedRows = true;
            }
            if (hasSelectedRows == true)
            {
                bool hasInvalidRows = true;
                for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                {
                    if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "0")
                        hasInvalidRows = false;
                }
                if (hasInvalidRows == true)
                {

                    if (MessageBox.Show("Se realizará el proceso de creación de los archivos de exportación a SIIGO de los movimientos seleccionados.\n\n Desea continuar?", "Exportación de movimientos a SIIGO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                        {
                            if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "1")
                            {
                                lstPalletMovement.Add(new clsPalletbyCoilCellar(Convert.ToInt32(dgvPalletCellar.Rows[i].Cells[clmobencodsec.Index].Value), true));
                                lstPalletMovement[i].siigoCellar = dgvPalletCellar.Rows[i].Cells[clmsiigocellar.Index].Value.ToString();
                                lstPalletMovement[i].siigoMovement = dgvPalletCellar.Rows[i].Cells[clmsiigomovement.Index].Value.ToString();
                                lstPalletMovement[i].siigoCode = dgvPalletCellar.Rows[i].Cells[clmsiigocode.Index].Value.ToString();
                                lstPalletMovement[i].siigoReference = dgvPalletCellar.Rows[i].Cells[clmsiigoreference.Index].Value.ToString();
                            }
                        }

                        frmExportPalletShippingRar winRar = new frmExportPalletShippingRar(lstPalletMovement);
                        winRar.ShowDialog();
                    }
                }
                else
                    MessageBox.Show("Hay películas que no han sido validadas por no tener su correspondiente código de siigo, revise estos códigos para continuar.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            else
                MessageBox.Show("No ha seleccionado ninguna orden de venta para ser exportada.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }
    }
}
