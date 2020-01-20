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
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace BPS.Lite
{
    public partial class frmBackLoad : Form
    {
        List<clsPallet> lstPallets = new List<clsPallet>();
        bool executeFilter = true;
        delegate void showLoading();
        delegate void HideLoading();

        showLoading showLoadImage;
        HideLoading hideLoadImage;

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstPallets = clsPallet.getListForBackLoadReload();
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
            var demoThread = new Thread(new ThreadStart(this.fillPalletInfo));
            demoThread.Start();
            demoThread.Priority = ThreadPriority.Highest;

            //fillPalletInfo();

            List<string> lstProducts = new List<string>();
            List<int> lstWidths = new List<int>();
            List<string> lstWidths2 = new List<string>();
            List<string> lstCustomers = new List<string>();
            List<string> lstSalesOrderNumber = new List<string>();
            List<string> lstCoilCellar = new List<string>();
            List<string> lstAntique = new List<string>();
            List<string> lstOrigin = new List<string>();

            lstProducts = lstPallets.Select(p => p.productCode).Distinct().ToList();
            lstWidths2 = lstPallets.Select(p => p.productWidth).Distinct().ToList();
            lstWidths = lstPallets.Select(p => Convert.ToInt32(p.productWidth)).Distinct().ToList();
            lstCustomers = lstPallets.Select(p => p.customerName).Distinct().ToList();

            lstSalesOrderNumber = lstPallets.Select(p => p.salesOrderNumber).Distinct().ToList();
            lstCoilCellar = lstPallets.Select(p => p.coilCellarName).Distinct().ToList();
            lstOrigin = lstPallets.Select(p => p.origin).Distinct().ToList();

            lstAntique.Add("Baja");
            lstAntique.Add("Media");
            lstAntique.Add("Alta");

            lstProducts.Sort();
            lstCustomers.Sort();
            lstSalesOrderNumber.Sort();
            lstCoilCellar.Sort();
            lstAntique.Sort();

            cmbAntique.Items.Clear();
            cmbCustomer.Items.Clear();
            cmbFilm.Items.Clear();
            cmbOrder.Items.Clear();
            cmbOrigin.Items.Clear();

            for (int i = 0; i < lstProducts.Count; i++)
                cmbFilm.Items.Add(lstProducts[i]);

            for (int i = 0; i < lstOrigin.Count; i++)
                cmbOrigin.Items.Add(lstOrigin[i]);

            for (int i = 0; i < lstCustomers.Count; i++)
                cmbCustomer.Items.Add(lstCustomers[i]);

            for (int i = 0; i < lstSalesOrderNumber.Count; i++)
                cmbOrder.Items.Add(lstSalesOrderNumber[i]);

            for (int i = 0; i < lstAntique.Count; i++)
                cmbAntique.Items.Add(lstAntique[i]);

            for (int i = 0; i < lstCoilCellar.Count; i++)
                lstbCoilCellar.Items.Add(lstCoilCellar[i]);

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
                    if (dgvDetails.Rows[i].Cells[clmCellar.Index].Value != null)
                    {
                        switch (dgvDetails.Rows[i].Cells[clmCellar.Index].Value.ToString())
                        {
                            case "Empaque":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(207, 234, 254);
                                break;
                            case "Proceso":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
                                break;
                            case "Producto Terminado":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(176, 247, 182);
                                break;
                            case "Stock Local":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(188, 188, 254);
                                break;
                            case "Metalizado":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(177, 211, 185);
                                break;
                            case "Bajas":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(249, 196, 183);
                                break;
                            case "Stock Perú":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(247, 202, 153);
                                break;
                            case "Base para metalizar":
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
                    if (dgvDetails.Rows[i].Cells[clmCellar.Index].Value != null)
                    {
                        if (dgvDetails.Rows[i].Cells[clmCellar.Index].Value.ToString() != "")
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

        public frmBackLoad()
        {
            InitializeComponent();
            getPalletList();
        }

        private void getPalletList()
        {
            showLoadImage = new showLoading(showLoadingDelegate);
            hideLoadImage = new HideLoading(hideLoadingDelegate);
        }

        delegate void fillPalletInfoDelegate();

        private void fillPalletInfo()
        {
            if (this.InvokeRequired)
            {
                fillPalletInfoDelegate pop = new fillPalletInfoDelegate(fillPalletInfo);
                this.Invoke(pop);
            }
            else
            {
                int palletCount = 0;
                double palletTotalWeight = 0;
                double palletTotalStock = 0;
                double palletTotalSalesOrder = 0;
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

                    for (int i = 0; i < lstPallets.Count; i++)
                    {
                        bool flgInclude = false;
                        bool flgOKFilm = false;
                        bool flgOKOrigin = false;
                        bool flgOKCustomer = false;
                        bool flgOKSalesOrder = false;
                        bool flgOKExtrusionDate = false;
                        bool flgOKAntique = false;
                        bool flgOKCoilCellar = false;
                        bool flgOKWidth = false;


                        if (cmbFilm.Text != "" || cmbCustomer.Text != "" || cmbOrder.Text != "" || cmbFilm.SelectedIndex > -1 || cmbCustomer.SelectedIndex > -1 || cmbOrder.SelectedIndex > -1 || cmbAntique.SelectedIndex > -1 || chkExtrusionDate.Checked == true || chkCoilCellar.Checked == true || (txtWidthFrom.Text != "" && txtWidthFrom.Text != "0") || cmbAntique.SelectedIndex > -1 || cmbAntique.Text != string.Empty)
                        {
                            //Film
                            if (cmbFilm.SelectedIndex > -1 || cmbFilm.Text != "")
                            {
                                if (lstPallets[i].productCode.ToUpper().StartsWith(cmbFilm.Text.ToString().ToUpper()))
                                    flgOKFilm = true;
                            }
                            if (cmbFilm.Text == "" && cmbFilm.SelectedIndex == -1)
                                flgOKFilm = true;


                            //Origin
                            if (cmbOrigin.SelectedIndex > -1)
                            {
                                if (lstPallets[i].origin.ToUpper() == cmbOrigin.SelectedItem.ToString().ToUpper())
                                    flgOKOrigin = true;
                            }
                            if (cmbOrigin.SelectedIndex == -1)
                                flgOKOrigin = true;

                            //Customer
                            if (cmbCustomer.SelectedIndex > -1 || cmbCustomer.Text != "")
                            {
                                if (lstPallets[i].customerName.ToUpper().StartsWith(cmbCustomer.Text.ToString().ToUpper()))
                                    flgOKCustomer = true;
                            }
                            if (cmbCustomer.Text == "" && cmbCustomer.SelectedIndex == -1)
                                flgOKCustomer = true;

                            //Sales Order
                            if (cmbOrder.Text != "" || cmbOrder.SelectedIndex > -1)
                            {
                                if (lstPallets[i].salesOrderNumber.StartsWith(cmbOrder.Text))
                                    flgOKSalesOrder = true;
                            }
                            if (cmbOrder.Text == "" && cmbOrder.SelectedIndex == -1)
                                flgOKSalesOrder = true;

                            //Extrusion Date
                            if (chkExtrusionDate.Checked == true)
                            {
                                if (lstPallets[i].createdDate >= dtpInitDate.Value && lstPallets[i].createdDate <= dtpEndDate.Value)
                                    flgOKExtrusionDate = true;
                            }
                            else
                                flgOKExtrusionDate = true;

                            //Coil cellar
                            if (chkCoilCellar.Checked == true)
                            {
                                for (int j = 0; j < lstbCoilCellar.SelectedItems.Count; j++)
                                {
                                    if (lstPallets[i].coilCellarName.ToUpper().StartsWith(lstbCoilCellar.SelectedItems[j].ToString().ToUpper()))
                                        flgOKCoilCellar = true;
                                }
                            }
                            else
                                flgOKCoilCellar = true;

                            if (txtWidthFrom.Text != "" && txtWidthFrom.Text != "0")
                            {
                                if (txtWidthTo.Text != "" && txtWidthTo.Text != "0")
                                {
                                    if (Convert.ToInt32(lstPallets[i].productWidth) >= Convert.ToInt32(txtWidthFrom.Text) && Convert.ToInt32(lstPallets[i].productWidth) <= Convert.ToInt32(txtWidthTo.Text))
                                        flgOKWidth = true;
                                }
                                else
                                {
                                    if (Convert.ToInt32(lstPallets[i].productWidth) == Convert.ToInt32(txtWidthFrom.Text))
                                        flgOKWidth = true;
                                }
                            }
                            else
                                flgOKWidth = true;

                            //Antique
                            if (cmbAntique.Text != "" || cmbAntique.SelectedIndex > -1)
                            {
                                TimeSpan ts = DateTime.Now - lstPallets[i].extrusionDate;

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

                            if (flgOKFilm == true && flgOKOrigin == true && flgOKCustomer == true && flgOKSalesOrder == true && flgOKExtrusionDate == true && flgOKAntique == true && flgOKCoilCellar == true && flgOKWidth == true && flgOKAntique == true)
                                flgInclude = true;
                        }
                        else
                            flgInclude = true;

                        if (flgInclude == true)
                        {
                            palletCount++;
                            palletTotalWeight += Math.Round(lstPallets[i].netWeight, 2);
                            if (lstPallets[i].customerName == "STOCK")
                                palletTotalStock += Math.Round(lstPallets[i].netWeight, 2);
                            else
                                palletTotalSalesOrder += Math.Round(lstPallets[i].netWeight, 2);

                            if (productCode == "")
                                productCode = (lstPallets.Count > 0) ? lstPallets[i].productCode : "";

                            if (lstPallets[i].productCode == productCode)
                            {
                                totalNetWeight += Math.Round(lstPallets[i].netWeight, 2);
                                totalPalletsByProduct++;
                            }
                            else
                            {
                                dgvDetails.Rows.Add();
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = productCode;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(totalNetWeight, 2);
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Lite.Properties.Resources.clear;

                                for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                                {
                                    Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
                                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                                }

                                productCode = lstPallets[i].productCode;
                                totalNetWeight = Math.Round(lstPallets[i].netWeight, 2);
                                totalPalletsByProduct = 1;
                            }

                            dgvDetails.Rows.Add();
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = lstPallets[i].codsec;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCode.Index].Value = lstPallets[i].code;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = lstPallets[i].productCode;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstPallets[i].productWidth;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDiameter.Index].Value = lstPallets[i].productAbbreviation;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCore.Index].Value = lstPallets[i].productCore;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstPallets[i].netWeight, 2).ToString();
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmOrigin.Index].Value = lstPallets[i].origin; // lstPallets[i].code;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmSalesOrder.Index].Value = lstPallets[i].salesOrderNumber;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstPallets[i].customerName;
                            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDestination.Index].Value = lstPallets[i].destination;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLotNumber.Index].Value = lstPallets[i].lotNumber;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = lstPallets[i].coilCellarName;
                            //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPalletNumber.Index].Value = lstPallets[i].palletNumber;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCoilsNumber.Index].Value = lstPallets[i].coilCount.ToString();
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmExtrusionDate.Index].Value = lstPallets[i].extrusionDate.ToString("dd/MM/yyyy");
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPosition.Index].Value = lstPallets[i].position;
                            TimeSpan ts = DateTime.Now - lstPallets[i].extrusionDate;

                            if (ts.Days < 120)
                            {
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Lite.Properties.Resources.bullet_green;
                                palletTotalNew += Math.Round(lstPallets[i].netWeight, 2);
                            }
                            else if (ts.Days >= 120 && ts.Days < 180)
                            {
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Lite.Properties.Resources.bullet_orange;
                                palletTotalMiddle += Math.Round(lstPallets[i].netWeight, 2);
                            }
                            else
                            {
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Lite.Properties.Resources.bullet_red;
                                palletTotalOld += Math.Round(lstPallets[i].netWeight, 2);
                            }

                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Lite.Properties.Resources.eye;
                            lastPosition = i;

                            bool isblock = false;

                            for (int k = 0; k < lstPallets[i].coilList.Count; k++)
                            {
                                if (lstPallets[i].coilList[k] == 1)
                                {
                                    isblock = true;
                                    break;
                                }
                                else
                                    isblock = false;
                            }
                            if (isblock)
                            {
                                for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                                {
                                    Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
                                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.ForeColor = Color.Red;
                                }
                            }
                        }
                    }
                    if (lastPosition > -1)
                    {
                        dgvDetails.Rows.Add();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = productCode;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(totalNetWeight, 2);
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Lite.Properties.Resources.clear;

                        for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                        {
                            Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                        }

                        productCode = lstPallets[lastPosition].productCode;
                        totalNetWeight = Math.Round(lstPallets[lastPosition].netWeight, 2);
                        totalPalletsByProduct = 1;
                    }
                }

                lblTotalPallets.Text = palletCount.ToString();
                lblTotalWeight.Text = palletTotalWeight.ToString();
                lblTotalStockWeight.Text = palletTotalStock.ToString();
                lblTotalSalesOrderWeight.Text = palletTotalSalesOrder.ToString();
                lblTotalWeightNew.Text = palletTotalNew.ToString();
                lblTotalWeightMiddle.Text = palletTotalMiddle.ToString();
                lblTotalWeightOld.Text = palletTotalOld.ToString();

                colorateByCoilCellar();
            }
        }

        private void frmBackLoad_Load(object sender, EventArgs e)
        {
            Thread td = new Thread(new ThreadStart(this.loadMovements));
            td.Start();
        }

        private void txtFilm_TextChanged(object sender, EventArgs e)
        {
            //fillPalletInfo();
            var demoThread = new Thread(new ThreadStart(this.fillPalletInfo));
            demoThread.Start();
            demoThread.Priority = ThreadPriority.Highest;
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
            cmbOrigin.Text = "";
            cmbOrigin.SelectedIndex = -1;
            cmbOrder.SelectedIndex = -1;
            cmbOrder.Text = "";
            cmbAntique.SelectedIndex = -1;
            cmbAntique.Text = "";
            chkExtrusionDate.Checked = false;
            chkCoilCellar.Checked = false;
            txtWidthFrom.Clear();
            txtWidthTo.Clear();
            executeFilter = true;
            lstbCoilCellar.Items.Clear();
            fillPalletInfo();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDetails.Rows.Clear();
            //lstbCoilCellar.Items.Clear();
            //chkCoilCellar.Checked = false;
            Thread td = new Thread(new ThreadStart(this.loadMovements));
            td.Start();
        }

        private void cmbFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var demoThread = new Thread(new ThreadStart(this.fillPalletInfo));
                demoThread.Start();
                demoThread.Priority = ThreadPriority.Highest;
            }
            //fillPalletInfo();
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
                    frmPalletDetailTraceability winPalletDetailTraceability = new frmPalletDetailTraceability(Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
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

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT * from vwdepo;");
                
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Estado de Deposito";

                for (int i = 1; i < DS.Tables[0].Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = DS.Tables[0].Columns[i - 1].ToString();

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DS.Tables[0].Columns.Count; j++)
                    {
                        if (DS.Tables[0].Rows[i][j].ToString() != null)
                            worksheet.Cells[i + 2, j + 1] = DS.Tables[0].Rows[i][j].ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Estado de Deposito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Estado de deposito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblNote_Click(object sender, EventArgs e)
        {
          
           
        }

        private void grpbFooter_Enter(object sender, EventArgs e)
        {
            try
            {

                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Estado de Deposito";

                for (int i = 1; i < dgvDetails.Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = dgvDetails.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvDetails.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvDetails.Columns.Count; j++)
                    {
                        if (dgvDetails.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvDetails.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Estado de Deposito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Estado de deposito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT * from vwdepo;");

                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Estado de Deposito - Bobinas";

                for (int i = 1; i < DS.Tables[0].Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = DS.Tables[0].Columns[i - 1].ToString();

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DS.Tables[0].Columns.Count; j++)
                    {
                        if (DS.Tables[0].Rows[i][j].ToString() != null)
                            worksheet.Cells[i + 2, j + 1] = DS.Tables[0].Rows[i][j].ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Estado de Deposito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Estado de Deposito - Bobinas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 97-2003 WorkBook|*.xls|Excel WorkBook|*.xlsx|All Excel Files|*.xls;*.xlsx";
            string filename = System.IO.Path.GetFileName(sfd.FileName);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Paste clipboard results to worksheet range
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                // For some reason column A is always blank in the worksheet.
                // Delete blank column A and select cell A1
                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dgvDetails.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            
            
            /*try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Estado de Deposito - Pallets";

                for (int i = 2; i < dgvDetails.Columns.Count + 1; i++)
                    worksheet.Cells[1, i-1] = dgvDetails.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    for (int j = 1; j < dgvDetails.Columns.Count-2; j++)
                    {
                        if (dgvDetails.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j] = dgvDetails.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Estado de Deposito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Estado de Deposito - Pallets", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void copyAlltoClipboard()
        {
            dgvDetails.SelectAll();
            DataObject dataObj = dgvDetails.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}
