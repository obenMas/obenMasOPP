using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;
using System.Threading;

namespace BPS
{
    public partial class frmReprocessBackLoad : Form
    {
        List<clsMillPalletbyCoilCellar> lstMillPallets = new List<clsMillPalletbyCoilCellar>();
        bool executeFilter = true;
        delegate void showLoading();
        delegate void HideLoading();

        showLoading showLoadImage;
        HideLoading hideLoadImage;

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstMillPallets = clsMillPalletbyCoilCellar.getListForReprocessBackLoad();
            this.Invoke(hideLoadImage);
        }

        private void showLoadingDelegate()
        {
            pbxLoading.Visible = true;
            grpbFilters.Enabled = false;
            lblLoading.Visible = true;
        }
        private void hideLoadingDelegate()
        {
            fillPalletInfo();

            List<string> lstProducts = new List<string>();
            List<string> lstCustomers = new List<string>();
            List<string> lstSalesOrderNumber = new List<string>();
            List<string> lstCoilCellar = new List<string>();
            List<string> lstAntique = new List<string>();
            List<string> lstOrderDuply = new List<string>();

            for (int i = 0; i < lstMillPallets.Count; i++)
            {
                //Products
                bool flgIsProductInList = false;
                for (int j = 0; j < lstProducts.Count; j++)
                {
                    if (lstProducts[j] == lstMillPallets[i].product)
                    {
                        flgIsProductInList = true;
                        break;
                    }
                }
                if (flgIsProductInList == false)
                    lstProducts.Add(lstMillPallets[i].product);

                //Antique
                lstAntique.Add("Baja");
                lstAntique.Add("Media");
                lstAntique.Add("Alta");
                
                //Customers
                bool flgIsCustomerInList = false;
                for (int j = 0; j < lstCustomers.Count; j++)
                {
                    if (lstCustomers[j] == lstMillPallets[i].customer)
                    {
                        flgIsCustomerInList = true;
                        break;
                    }
                }
                if (flgIsCustomerInList == false)
                    lstCustomers.Add(lstMillPallets[i].customer);


                //Sales Order Number
                bool flgIsSalesOrderNumberInList = false;
                for (int j = 0; j < lstSalesOrderNumber.Count; j++)
                {
                    if (lstSalesOrderNumber[j] == lstMillPallets[i].code.ToString())
                    {
                        lstOrderDuply.Add(lstMillPallets[i].code.ToString());
                        flgIsSalesOrderNumberInList = true;
                        break;
                    }
                }
                if (flgIsSalesOrderNumberInList == false)
                    lstSalesOrderNumber.Add(lstMillPallets[i].code.ToString());

                //Coil Cellar
                lstCoilCellar.Add("Bodega Re-Proceso");
            }

            cmbAntique.Items.Clear();
            cmbCustomer.Items.Clear();
            cmbDuply.Items.Clear();
            cmbFilm.Items.Clear();
            cmbOrder.Items.Clear();

            lstProducts.Sort();
            lstCustomers.Sort();
            lstSalesOrderNumber.Sort();
            lstCoilCellar.Sort();
            lstAntique.Sort();
            lstAntique.Distinct().ToList();
            lstAntique = lstAntique.Distinct().ToList();
            lstCoilCellar = lstCoilCellar.Distinct().ToList();
            lstOrderDuply.Sort();

            for (int i = 0; i < lstProducts.Count; i++)
                cmbFilm.Items.Add(lstProducts[i]);

            for (int i = 0; i < lstCustomers.Count; i++)
                cmbCustomer.Items.Add(lstCustomers[i]);

            for (int i = 0; i < lstSalesOrderNumber.Count; i++)
                cmbOrder.Items.Add(lstSalesOrderNumber[i]);

            for (int i = 0; i < lstAntique.Count; i++)
                cmbAntique.Items.Add(lstAntique[i]);

            for (int i = 0; i < lstCoilCellar.Count; i++)
                lstbCoilCellar.Items.Add(lstCoilCellar[i]);

            if (lstOrderDuply.Count > 0)
            {
                lblduply.Visible = true;
                cmbDuply.Visible = true;
                for (int i = 0; i < lstOrderDuply.Count; i++)
                    cmbDuply.Items.Add(lstOrderDuply[i]);
            }
            else
            {
                lblduply.Visible = false;
                cmbDuply.Visible = false;
            }

            grpbFilters.Enabled = true;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }

        public void colorateByCoilCellar()
        {
            if (chkColorCoilCellar.Checked == true)
            {
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    if (dgvDetails.Rows[i].Cells[clmProduct.Index].Value != null && dgvDetails.Rows[i].Cells[clmPalletWeigth.Index].Value != null)
                    {
                        switch (dgvDetails.Rows[i].Cells[clmProduct.Index].Value.ToString())
                        {
                            case "Recuperado Transparente":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(207, 234, 254);
                                break;
                            case "Recuperado PC":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
                                break;
                            case "Recuperado WC":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(176, 247, 182);
                                break;
                            case "Recuperado OH":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(188, 188, 254);
                                break;
                            case "Metalizado":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(177, 211, 185);
                                break;
                            case "Plástico Grueso":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(249, 196, 183);
                                break;
                            case "Transiciones":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(247, 202, 153);
                                break;
                            case "Tortas":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(241, 218, 239);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    if (dgvDetails.Rows[i].Cells[clmProduct.Index].Value != null)
                    {
                        if (dgvDetails.Rows[i].Cells[clmProduct.Index].Value.ToString() != "" && dgvDetails.Rows[i].Cells[clmPalletWeigth.Index].Value != null)
                        {
                            for (int j = 0; j < dgvDetails.Columns.Count; j++)
                            {
                                dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.White;
                            }
                        }
                    }
                }
            }
        }

        public frmReprocessBackLoad()
        {
            InitializeComponent();
            getPalletList();
        }
        private void getPalletList()
        {
            showLoadImage = new showLoading(showLoadingDelegate);
            hideLoadImage = new HideLoading(hideLoadingDelegate);
        }
        private void fillPalletInfo()
        {
            int palletCount = 0;
            double palletTotalWeight = 0;
            double palletTotalNew = 0;
            double palletTotalMiddle = 0;
            double palletTotalOld = 0;

            if (executeFilter == true)
            {
                string productCode = "";
                double totalNetWeight = 0;
                int totalPalletsByProduct = 0;
                int lastPosition = -1;

                dgvDetails.Rows.Clear();

                for (int i = 0; i < lstMillPallets.Count; i++)
                {
                    bool flgInclude = false;
                    bool flgOKFilm = false;
                    bool flgOKCustomer = false;
                    bool flgOKSalesOrder = false;
                    bool flgOKExtrusionDate = false;
                    bool flgOKAntique = false;
                    bool flgOKCoilCellar = false;
                    bool flgOKWeigth = false;
                    bool flgOKDuply = false;


                    if (cmbFilm.Text != "" || cmbCustomer.Text != "" || cmbOrder.Text != "" || cmbFilm.SelectedIndex > -1 || cmbCustomer.SelectedIndex > -1 || cmbOrder.SelectedIndex > -1 || cmbAntique.SelectedIndex > -1 || chkExtrusionDate.Checked == true || chkCoilCellar.Checked == true || (txtWidthFrom.Text != "" && txtWidthFrom.Text != "0") || cmbAntique.SelectedIndex > -1 || cmbAntique.Text != string.Empty || cmbDuply.Text != "" || cmbDuply.SelectedIndex > -1)
                    {
                        //Film
                        if (cmbFilm.SelectedIndex > -1 || cmbFilm.Text != "")
                        {
                            if (lstMillPallets[i].product.ToUpper().StartsWith(cmbFilm.Text.ToString().ToUpper()))
                                flgOKFilm = true;
                        }
                        if (cmbFilm.Text == "" && cmbFilm.SelectedIndex == -1)
                            flgOKFilm = true;

                        //Customer
                        if (cmbCustomer.SelectedIndex > -1 || cmbCustomer.Text != "")
                        {
                            if (lstMillPallets[i].customer.ToUpper().StartsWith(cmbCustomer.Text.ToString().ToUpper()))
                                flgOKCustomer = true;
                        }
                        if (cmbCustomer.Text == "" && cmbCustomer.SelectedIndex == -1)
                            flgOKCustomer = true;

                        //Sales Order
                        if (cmbOrder.Text != "" || cmbOrder.SelectedIndex > -1)
                        {
                            if (lstMillPallets[i].order.ToString().StartsWith(cmbOrder.Text))
                                flgOKSalesOrder = true;
                        }
                        if (cmbOrder.Text == "" && cmbOrder.SelectedIndex == -1)
                            flgOKSalesOrder = true;

                        //Sales Order
                        if (cmbDuply.Text != "" || cmbDuply.SelectedIndex > -1)
                        {
                            if (lstMillPallets[i].order.ToString().StartsWith(cmbDuply.Text))
                                flgOKDuply = true;
                        }
                        if (cmbDuply.Text == "" && cmbDuply.SelectedIndex == -1)
                            flgOKDuply = true;

                        //Extrusion Date
                        if (chkExtrusionDate.Checked == true)
                        {
                            if (lstMillPallets[i].date >= dtpInitDate.Value && lstMillPallets[i].date <= dtpEndDate.Value)
                                flgOKExtrusionDate = true;
                        }
                        else
                            flgOKExtrusionDate = true;

                        //Coil cellar
                        if (chkCoilCellar.Checked == true)
                        {
                            for (int j = 0; j < lstbCoilCellar.SelectedItems.Count; j++)
                            {
                                if (("Bodega Re-Proceso").ToString().ToUpper().StartsWith(lstbCoilCellar.SelectedItems[j].ToString().ToUpper()))
                                    flgOKCoilCellar = true;
                            }
                        }
                        else
                            flgOKCoilCellar = true;

                        if (txtWidthFrom.Text != "" && txtWidthFrom.Text != "0")
                        {
                            if (txtWidthTo.Text != "" && txtWidthTo.Text != "0")
                            { 
                                if (lstMillPallets[i].netweigth >= Convert.ToDouble(txtWidthFrom.Text) && lstMillPallets[i].netweigth <= Convert.ToDouble(txtWidthTo.Text))
                                    flgOKWeigth = true;
                            }
                            else
                            {
                                if (lstMillPallets[i].netweigth == Convert.ToDouble(txtWidthFrom.Text))
                                    flgOKWeigth = true;
                            }
                        }
                        else
                            flgOKWeigth = true;

                        //Antique
                        if (cmbAntique.Text != "" || cmbAntique.SelectedIndex > -1)
                        {
                            TimeSpan ts = DateTime.Now - lstMillPallets[i].date;

                            if (cmbAntique.Text.ToUpper().ToString() == "BAJA")
                            {
                                if (ts.Days < 120)
                                    flgOKAntique = true;
                            }
                            else if (cmbAntique.Text.ToUpper().ToString() == "MEDIA")
                            {
                                if (ts.Days >= 120 && ts.Days < 180)
                                    flgOKAntique = true;
                            }
                            else if (cmbAntique.Text.ToUpper().ToString() == "ALTA")
                            {
                                if (ts.Days >= 180)
                                    flgOKAntique = true;
                            }
                            else
                                flgOKAntique = true;
                        }
                        else
                            flgOKAntique = true;

                        if (flgOKFilm == true && flgOKCustomer == true && flgOKSalesOrder == true && flgOKExtrusionDate == true && flgOKAntique == true && flgOKCoilCellar == true && flgOKWeigth == true && flgOKAntique == true && flgOKDuply == true)
                            flgInclude = true;
                    }
                    else
                        flgInclude = true;

                    if (flgInclude == true)
                    {
                        palletCount++;
                        palletTotalWeight += Math.Round(lstMillPallets[i].netweigth, 1);
                        
                        if (productCode == "")
                            productCode = (lstMillPallets.Count > 0) ? lstMillPallets[i].product : "";

                        if (lstMillPallets[i].product == productCode)
                        {
                            totalNetWeight += Math.Round(lstMillPallets[i].netweigth, 1);
                            totalPalletsByProduct++;
                        }
                        else
                        {
                            dgvDetails.Rows.Add();
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmProduct.Index].Value = productCode;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmProductCode.Index].Value = clsMillProduct.getExternalCode(productCode);
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(totalNetWeight, 1);
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.clear;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.clear;

                            for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                            {
                                Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                            }

                            productCode = lstMillPallets[i].product;
                            totalNetWeight = Math.Round(lstMillPallets[i].netweigth, 1);
                            totalPalletsByProduct = 1;
                        }

                        dgvDetails.Rows.Add();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = lstMillPallets[i].codsec;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmfkMill.Index].Value = lstMillPallets[i].fkmillpallet;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmProduct.Index].Value = lstMillPallets[i].product;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmProductCode.Index].Value = clsMillProduct.getExternalCode(lstMillPallets[i].product);
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPalletWeigth.Index].Value = Math.Round(lstMillPallets[i].palletweigth, 2, MidpointRounding.AwayFromZero);
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmGrossWeigth.Index].Value = Math.Round(lstMillPallets[i].grossweigth, 2, MidpointRounding.AwayFromZero);
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstMillPallets[i].netweigth, 2, MidpointRounding.AwayFromZero);
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmSalesOrder.Index].Value = lstMillPallets[i].order;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstMillPallets[i].customer;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = "Bodega Re-Proceso";
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDensity.Index].Value = Math.Round(lstMillPallets[i].density, 4, MidpointRounding.AwayFromZero);
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmMill.Index].Value = lstMillPallets[i].millName;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDate.Index].Value = lstMillPallets[i].date.ToString("dd/MM/yyyy");

                        TimeSpan ts = DateTime.Now - lstMillPallets[i].date;

                        if (ts.Days < 120)
                        {
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.bullet_green;
                            palletTotalNew += Math.Round(lstMillPallets[i].netweigth, 1);
                        }
                        else if (ts.Days >= 120 && ts.Days < 180)
                        {
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.bullet_orange;
                            palletTotalMiddle += Math.Round(lstMillPallets[i].netweigth, 1);
                        }
                        else
                        {
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.bullet_red;
                            palletTotalOld += Math.Round(lstMillPallets[i].netweigth, 1);
                        }

                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.eye;
                        lastPosition = i;
                    }
                }
                if (lastPosition > -1)
                {
                    dgvDetails.Rows.Add();
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmProduct.Index].Value = productCode;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmProductCode.Index].Value = clsMillProduct.getExternalCode(productCode);
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(totalNetWeight, 1);
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.clear;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.clear;

                    for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                    {
                        Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                    }

                    productCode = lstMillPallets[lastPosition].product;
                    totalNetWeight = Math.Round(lstMillPallets[lastPosition].netweigth, 1);
                    totalPalletsByProduct = 1;
                }
            }

            lblTotalPallets.Text = palletCount.ToString();
            lblTotalWeight.Text = palletTotalWeight.ToString();
            lblTotalWeightNew.Text = palletTotalNew.ToString();
            lblTotalWeightMiddle.Text = palletTotalMiddle.ToString();
            lblTotalWeightOld.Text = palletTotalOld.ToString();
            colorateByCoilCellar();
        }

        private void frmReprocessBackLoad_Load(object sender, EventArgs e)
        {
            Thread td = new Thread(new ThreadStart(this.loadMovements));
            td.Start();
        }

        private void txtFilm_TextChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void txtSalesOrder_TextChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void chkExtrusionDate_CheckedChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }


        private void grpbFilters_Enter(object sender, EventArgs e)
        {

        }

        private void btnMainCoilClearFilters_Click(object sender, EventArgs e)
        {
            executeFilter = false;

            cmbFilm.SelectedIndex = -1;
            cmbFilm.Text = "";
            cmbCustomer.SelectedIndex = -1;
            cmbCustomer.Text = "";
            cmbOrder.SelectedIndex = -1;
            cmbOrder.Text = "";
            cmbAntique.SelectedIndex = -1;
            cmbAntique.Text = "";
            chkExtrusionDate.Checked = false;
            chkCoilCellar.Checked = false;
            txtWidthFrom.Clear();
            txtWidthTo.Clear();
            executeFilter = true;
            for (int i = 0; i < lstbCoilCellar.Items.Count - 1; i++)
                lstbCoilCellar.Items.RemoveAt(i);
            fillPalletInfo();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDetails.Rows.Clear();
            Thread td = new Thread(new ThreadStart(this.loadMovements));
            td.Start();
        }

        private void cmbFilm_KeyDown(object sender, KeyEventArgs e)
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

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmDetail.Index)
            {
                if (Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmCodsec.Index].Value) != 0)
                {
                    frmMillPalletDetail winPalletDetailTraceability = new frmMillPalletDetail(Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmCodsec.Index].Value),Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmfkMill.Index].Value));
                    winPalletDetailTraceability.ShowDialog(this);
                }
            }
        }

        private void lstbCoilCellar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbCoilCellar.SelectedItems.Count > 0)
            {
                if (chkCoilCellar.Checked == false)
                    chkCoilCellar.Checked = true;
                else
                    fillPalletInfo();
            }
        }

        private void chkCoilCellar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoilCellar.Checked == false)
                lstbCoilCellar.ClearSelected();

            fillPalletInfo();
        }

        private void txtWidthFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void txtWidthTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void chkColorCoilCellar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkColorCoilCellar.Checked == true)
                grpbColorCode.Visible = true;
            else
                grpbColorCode.Visible = false;

            colorateByCoilCellar();
        }

        private void cmbAntique_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbAntique_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbDuply_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void dgvDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar el pallet seleccionado?","Re-Procesado",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign,false) == DialogResult.Yes)
                {
                    if (clsMillPalletbyCoilCellar.toDelete(Convert.ToInt32(dgvDetails.CurrentRow.Cells[clmCodsec.Index].Value)))
                    {
                        MessageBox.Show("Pallet Eliminado Correctamente", "Listado Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        dgvDetails.Rows.Clear();
                        Thread td = new Thread(new ThreadStart(this.loadMovements));
                        td.Start();
                    } 
                }
            }
        }
    }
}