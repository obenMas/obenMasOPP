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
    public partial class frmSummaryInventory : Form
    {
        List<clsPallet> lstPallets = new List<clsPallet>();
        List<clsDetailInventory> lstInventory = new List<clsDetailInventory>();
        int codsec = 0;
        bool executeFilter = true;
        delegate void showLoading();
        delegate void HideLoading();

        showLoading showLoadImage;
        HideLoading hideLoadImage;

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstPallets = clsPallet.getListForInventory(codsec);
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
            List<int> lstWidths = new List<int>();
            List<string> lstCustomers = new List<string>();
            List<string> lstSalesOrderNumber = new List<string>();
            List<string> lstCoilCellar = new List<string>();


            for (int i = 0; i < lstPallets.Count; i++)
            {
                //Products
                bool flgIsProductInList = false;
                for (int j = 0; j < lstProducts.Count; j++)
                {
                    if (lstProducts[j] == lstPallets[i].product.code)
                    {
                        flgIsProductInList = true;
                        break;
                    }
                }
                if (flgIsProductInList == false)
                    lstProducts.Add(lstPallets[i].product.code);


                //Widths
                bool flgIsWidthInList = false;
                for (int j = 0; j < lstWidths.Count; j++)
                {
                    if (lstWidths[j] == lstPallets[i].product.width)
                    {
                        flgIsWidthInList = true;
                        break;
                    }
                }
                if (flgIsWidthInList == false)
                    lstWidths.Add(Convert.ToInt32(lstPallets[i].product.width));


                //Customers
                bool flgIsCustomerInList = false;
                for (int j = 0; j < lstCustomers.Count; j++)
                {
                    if (lstCustomers[j] == lstPallets[i].customerName)
                    {
                        flgIsCustomerInList = true;
                        break;
                    }
                }
                if (flgIsCustomerInList == false)
                    lstCustomers.Add(lstPallets[i].customerName);


                //Sales Order Number
                bool flgIsSalesOrderNumberInList = false;
                for (int j = 0; j < lstSalesOrderNumber.Count; j++)
                {
                    if (lstSalesOrderNumber[j] == lstPallets[i].salesOrderNumber)
                    {
                        flgIsSalesOrderNumberInList = true;
                        break;
                    }
                }
                if (flgIsSalesOrderNumberInList == false)
                    lstSalesOrderNumber.Add(lstPallets[i].salesOrderNumber);

                //Coil Cellar
                bool flgIsCoilCellar = false;
                for (int j = 0; j < lstCoilCellar.Count; j++)
                {
                    if (lstCoilCellar[j] == lstPallets[i].coilCellarName)
                    {
                        flgIsCoilCellar = true;
                        break;
                    }
                }
                if (flgIsCoilCellar == false)
                    lstCoilCellar.Add(lstPallets[i].coilCellarName);

            }
            lstProducts.Sort();
            lstCustomers.Sort();
            lstSalesOrderNumber.Sort();
            lstCoilCellar.Sort();

            for (int i = 0; i < lstProducts.Count; i++)
                cmbFilm.Items.Add(lstProducts[i]);


            for (int i = 0; i < lstCustomers.Count; i++)
                cmbCustomer.Items.Add(lstCustomers[i]);

            for (int i = 0; i < lstSalesOrderNumber.Count; i++)
                cmbOrder.Items.Add(lstSalesOrderNumber[i]);

            //for (int i = 0; i < lstCoilCellar.Count; i++)
            //    cmbCoilCellar.Items.Add(lstCoilCellar[i]);

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
        public frmSummaryInventory()
        {
            InitializeComponent();
            getPalletList();
        }

        public frmSummaryInventory(int codsec)
        {
            InitializeComponent();
            this.codsec = codsec;
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


                    if (cmbFilm.Text != "" || cmbCustomer.Text != "" || cmbOrder.Text != "" || cmbFilm.SelectedIndex > -1 || cmbCustomer.SelectedIndex > -1 || cmbOrder.SelectedIndex > -1 || cmbAntique.SelectedIndex > -1 || chkExtrusionDate.Checked == true || chkCoilCellar.Checked == true || (txtWidthFrom.Text != "" && txtWidthFrom.Text != "0"))
                    {
                        //Film
                        if (cmbFilm.SelectedIndex > -1 || cmbFilm.Text != "")
                        {
                            if (lstPallets[i].product.code.ToUpper().StartsWith(cmbFilm.Text.ToString().ToUpper()))
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
                            {
                                flgOKExtrusionDate = true;
                            }
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
                                if (lstPallets[i].product.width >= Convert.ToInt32(txtWidthFrom.Text) && lstPallets[i].product.width <= Convert.ToInt32(txtWidthTo.Text))
                                    flgOKWidth = true;
                            }
                            else
                            {
                                if (lstPallets[i].product.width == Convert.ToInt32(txtWidthFrom.Text))
                                    flgOKWidth = true;
                            }
                        }
                        else
                            flgOKWidth = true;
                        
                        //Antique
                        flgOKAntique = true;

                        if (flgOKFilm == true && flgOKOrigin == true && flgOKCustomer == true && flgOKSalesOrder == true && flgOKExtrusionDate == true && flgOKAntique == true && flgOKCoilCellar == true && flgOKWidth == true)
                            flgInclude = true;
                    }
                    else
                    {
                        flgInclude = true;
                    }

                    if (flgInclude == true)
                    {
                        palletCount++;
                        palletTotalWeight += Math.Round(lstPallets[i].netWeight, 1);
                        if (lstPallets[i].customerName == "STOCK")
                            palletTotalStock += Math.Round(lstPallets[i].netWeight, 1);
                        else
                            palletTotalSalesOrder += Math.Round(lstPallets[i].netWeight, 1);

                        if (productCode == "")
                            productCode = (lstPallets.Count > 0) ? lstPallets[i].product.code : "";

                        if (lstPallets[i].product.code == productCode)
                        {
                            totalNetWeight += Math.Round(lstPallets[i].netWeight, 1);
                            totalPalletsByProduct++;
                        }
                        else
                        {
                            dgvDetails.Rows.Add();
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = productCode;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(totalNetWeight, 1);
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.clear;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.clear;

                            for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                            {
                                Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                            }

                            productCode = lstPallets[i].product.code;
                            totalNetWeight = Math.Round(lstPallets[i].netWeight, 1);
                            totalPalletsByProduct = 1;
                        }


                        dgvDetails.Rows.Add();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = lstPallets[i].codsec;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = lstPallets[i].product.code;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstPallets[i].product.width;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDiameter.Index].Value = lstPallets[i].product.DiameterAbbreviation;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCore.Index].Value = lstPallets[i].product.CoreValue;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstPallets[i].netWeight, 1).ToString();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmOrigin.Index].Value = lstPallets[i].origin;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmSalesOrder.Index].Value = lstPallets[i].salesOrderNumber;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstPallets[i].customerName;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDestination.Index].Value = lstPallets[i].destination;
                        
                        //string lotNumber = "";

                        //for (int j = 0; j < lstPallets[i].lstCoil.Count; j++)
                        //{
                        //    if (!lotNumber.Contains(lstPallets[i].lstCoil[j].lotNumber))
                        //        lotNumber += lstPallets[i].lstCoil[j].lotNumber + " / ";
                        //}
                        //if (lotNumber.EndsWith(" / "))
                        //    lotNumber = lotNumber.Substring(0, lotNumber.Length - 3);

                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLotNumber.Index].Value = lstPallets[i].lotNumber;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = lstPallets[i].coilCellarName;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPalletNumber.Index].Value = lstPallets[i].palletNumber;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCoilsNumber.Index].Value = lstPallets[i].coilCount.ToString();

                        //DateTime extrusionDate = DateTime.Now;

                        //for (int j = 0; j < lstPallets[i].lstCoil.Count; j++)
                        //{
                        //    if (lstPallets[i].lstCoil[0].extrusionDate < extrusionDate)
                        //        extrusionDate = lstPallets[i].lstCoil[j].extrusionDate;
                        //}
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmExtrusionDate.Index].Value = lstPallets[i].extrusionDate.ToString("dd/MM/yyyy");

                        TimeSpan ts = DateTime.Now - lstPallets[i].extrusionDate;

                        if (ts.Days < 120)
                        {
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.bullet_green;
                            palletTotalNew += Math.Round(lstPallets[i].netWeight, 1);
                        }
                        else if (ts.Days >= 120 && ts.Days < 180)
                        {
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.bullet_orange;
                            palletTotalMiddle += Math.Round(lstPallets[i].netWeight, 1);
                        }
                        else
                        {
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.bullet_red;
                            palletTotalOld += Math.Round(lstPallets[i].netWeight, 1);
                        }

                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.eye;
                        lastPosition = i;
                    }
                }
                if (lastPosition > -1)
                {
                    dgvDetails.Rows.Add();
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = productCode;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(totalNetWeight, 1);
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.clear;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.clear;

                    for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                    {
                        Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                    }

                    productCode = lstPallets[lastPosition].product.code;
                    totalNetWeight = Math.Round(lstPallets[lastPosition].netWeight, 1);
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

        private void frmBackLoad_Load(object sender, EventArgs e)
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
            cmbOrigin.Text = "";
            cmbOrigin.SelectedIndex = -1;
            cmbOrder.SelectedIndex = -1;
            cmbOrder.Text = "";
            cmbAntique.SelectedIndex = -1;
            cmbAntique.Text = "";
            chkExtrusionDate.Checked = false;
            chkCoilCellar.Checked = false;

            executeFilter = true;

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
    }
}
