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
    public partial class  frmSummaryInventoryVsBackload : Form
    {
        List<clsComparator> lstComparator = new List<clsComparator>();
        int codsec = 0;
        bool executeFilter = true;
        delegate void showLoading();
        delegate void HideLoading();

        showLoading showLoadImage;
        HideLoading hideLoadImage;

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstComparator = clsComparator.getComparatorShort(codsec);
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
            List<string> lstPosition = new List<string>();
            List<string> lstOrigin = new List<string>();


            for (int i = 0; i < lstComparator.Count; i++)
            {
                //Products
                bool flgIsProductInList = false;
                for (int j = 0; j < lstProducts.Count; j++)
                {
                    if (lstProducts[j] == lstComparator[i].productName)
                    {
                        flgIsProductInList = true;
                        break;
                    }
                }
                if (flgIsProductInList == false)
                    lstProducts.Add(lstComparator[i].productName);


                //Widths
                bool flgIsWidthInList = false;
                for (int j = 0; j < lstWidths.Count; j++)
                {
                    if (lstWidths[j] == lstComparator[i].width)
                    {
                        flgIsWidthInList = true;
                        break;
                    }
                }
                if (flgIsWidthInList == false)
                    lstWidths.Add(Convert.ToInt32(lstComparator[i].width));


                //Customers
                bool flgIsCustomerInList = false;
                for (int j = 0; j < lstCustomers.Count; j++)
                {
                    if (lstCustomers[j] == lstComparator[i].customerName)
                    {
                        flgIsCustomerInList = true;
                        break;
                    }
                }
                if (flgIsCustomerInList == false)
                    lstCustomers.Add(lstComparator[i].customerName);

                //Ubication
                bool flgIsPosition = false;
                for (int j = 0; j < lstPosition.Count; j++)
                {
                    if (lstPosition[j] == lstComparator[i].destination)
                    {
                        flgIsPosition = true;
                        break;
                    }
                }
                if (flgIsPosition == false)
                    lstPosition.Add(lstComparator[i].destination);


                //Sales Order Number
                bool flgIsSalesOrderNumberInList = false;
                for (int j = 0; j < lstSalesOrderNumber.Count; j++)
                {
                    if (lstSalesOrderNumber[j] == lstComparator[i].salesOrderNumber)
                    {
                        flgIsSalesOrderNumberInList = true;
                        break;
                    }
                }
                if (flgIsSalesOrderNumberInList == false)
                    lstSalesOrderNumber.Add(lstComparator[i].salesOrderNumber);

                //Coil Cellar
                bool flgIsCoilCellar = false;
                for (int j = 0; j < lstCoilCellar.Count; j++)
                {
                    if (lstCoilCellar[j] == lstComparator[i].coilCellarName)
                    {
                        flgIsCoilCellar = true;
                        break;
                    }
                }
                if (flgIsCoilCellar == false)
                    lstCoilCellar.Add(lstComparator[i].coilCellarName);

                //Origin
                bool flgIsOriginInList = false;
                for (int j = 0; j < lstOrigin.Count; j++)
                {
                    if (lstOrigin[j] == lstComparator[i].origin)
                    {
                        flgIsOriginInList = true;
                        break;
                    }
                }
                if (flgIsOriginInList == false)
                    lstOrigin.Add(lstComparator[i].origin);

            }
            lstProducts.Sort();
            lstCustomers.Sort();
            lstSalesOrderNumber.Sort();
            lstCoilCellar.Sort();
            lstPosition.Sort();
            lstOrigin.Sort();

            for (int i = 0; i < lstProducts.Count; i++)
                cmbFilm.Items.Add(lstProducts[i]);

            for (int i = 0; i < lstOrigin.Count; i++)
                cmbOrigin.Items.Add(lstOrigin[i]);

            for (int i = 0; i < lstCustomers.Count; i++)
                cmbCustomer.Items.Add(lstCustomers[i]);

            for (int i = 0; i < lstPosition.Count; i++)
                cmbPosition.Items.Add(lstPosition[i]);

            for (int i = 0; i < lstSalesOrderNumber.Count; i++)
                cmbOrder.Items.Add(lstSalesOrderNumber[i]);

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
                    if (dgvDetails.Rows[i].Cells[clminventory.Index].Value != null)
                    {
                        switch (dgvDetails.Rows[i].Cells[clminventory.Index].Value.ToString())
                        {
                            case "OK":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(207, 234, 254);
                                break;
                            case "Inventario":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
                                break;
                            case "Backload":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(176, 247, 182);
                                break;
                            //case "Stock Local":
                            //    for (int j = 0; j < dgvDetails.Columns.Count; j++)
                            //        dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(188, 188, 254);
                            //    break;
                            //case "Metalizado":
                            //    for (int j = 0; j < dgvDetails.Columns.Count; j++)
                            //        dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(177, 211, 185);
                            //    break;
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
                            //    break;
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
                    if (dgvDetails.Rows[i].Cells[clminventory.Index].Value != null)
                    {
                        if (dgvDetails.Rows[i].Cells[clminventory.Index].Value.ToString() != "")
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

        public frmSummaryInventoryVsBackload()
        {
            InitializeComponent();
            getPalletList();
        }

        public frmSummaryInventoryVsBackload(int codsec)
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

            if (executeFilter == true)
            {
                string productCode = "";
                double totalNetWeight = 0;
                int totalPalletsByProduct = 0;
                int lastPosition = -1;

                dgvDetails.Rows.Clear();

                for (int i = 0; i < lstComparator.Count; i++)
                {
                    bool flgInclude = false;
                    bool flgOKFilm = false;
                    bool flgOKOrigin = false;
                    bool flgOKCustomer = false;
                    bool flgOKSalesOrder = false;
                    bool flgOKCoilCellar = false;
                    bool flgOKWidth = false;
                    bool flgOKPosition = false;


                    if (cmbFilm.Text != "" || cmbCustomer.Text != "" || cmbOrder.Text != "" || cmbFilm.SelectedIndex > -1 || cmbCustomer.SelectedIndex > -1 || cmbOrder.SelectedIndex > -1 || chkCoilCellar.Checked == true || (txtWidthFrom.Text != "" && txtWidthFrom.Text != "0" || cmbPosition.SelectedIndex > -1))
                    {
                        //Film
                        if (cmbFilm.SelectedIndex > -1 || cmbFilm.Text != "")
                        {
                            if (lstComparator[i].productName.ToUpper().StartsWith(cmbFilm.Text.ToString().ToUpper()))
                                flgOKFilm = true;
                        }
                        if (cmbFilm.Text == "" && cmbFilm.SelectedIndex == -1)
                            flgOKFilm = true;


                        //Origin
                        if (cmbOrigin.SelectedIndex > -1)
                        {
                            if (lstComparator[i].origin.ToUpper() == cmbOrigin.SelectedItem.ToString().ToUpper())
                                flgOKOrigin = true;
                        }
                        if (cmbOrigin.SelectedIndex == -1)
                            flgOKOrigin = true;

                        //Position
                        if (cmbPosition.SelectedIndex > -1)
                        {
                            if (lstComparator[i].destination.ToUpper().StartsWith(cmbPosition.Text.ToString().ToUpper()))
                                flgOKPosition = true;
                        }
                        if (cmbPosition.SelectedIndex == -1)
                            flgOKPosition = true;

                        //Customer
                        if (cmbCustomer.SelectedIndex > -1 || cmbCustomer.Text != "")
                        {
                            if (lstComparator[i].customerName.ToUpper().StartsWith(cmbCustomer.Text.ToString().ToUpper()))
                                flgOKCustomer = true;
                        }
                        if (cmbCustomer.Text == "" && cmbCustomer.SelectedIndex == -1)
                            flgOKCustomer = true;

                        //Sales Order
                        if (cmbOrder.Text != "" || cmbOrder.SelectedIndex > -1)
                        {
                            if (lstComparator[i].salesOrderNumber.StartsWith(cmbOrder.Text))
                                flgOKSalesOrder = true;
                        }
                        if (cmbOrder.Text == "" && cmbOrder.SelectedIndex == -1)
                            flgOKSalesOrder = true;

                        //Coil cellar
                        if (chkCoilCellar.Checked == true)
                        {
                            for (int j = 0; j < lstbCoilCellar.SelectedItems.Count; j++)
                            {
                                if (lstComparator[i].coilCellarName.ToUpper().StartsWith(lstbCoilCellar.SelectedItems[j].ToString().ToUpper()))
                                    flgOKCoilCellar = true;
                            }
                        }
                        else
                            flgOKCoilCellar = true;

                        if (txtWidthFrom.Text != "" && txtWidthFrom.Text != "0")
                        {
                            if (txtWidthTo.Text != "" && txtWidthTo.Text != "0")
                            { 
                                if (lstComparator[i].width >= Convert.ToInt32(txtWidthFrom.Text) && lstComparator[i].width <= Convert.ToInt32(txtWidthTo.Text))
                                    flgOKWidth = true;
                            }
                            else
                            {
                                if (lstComparator[i].width == Convert.ToInt32(txtWidthFrom.Text))
                                    flgOKWidth = true;
                            }
                        }
                        else
                            flgOKWidth = true;

                        if (flgOKFilm == true && flgOKOrigin == true &&  flgOKPosition == true && flgOKCustomer == true && flgOKSalesOrder == true && flgOKCoilCellar == true && flgOKWidth == true)
                            flgInclude = true;
                    }
                    else
                        flgInclude = true;

                    if (flgInclude == true)
                    {
                        palletCount++;
                        palletTotalWeight += Math.Round(lstComparator[i].netWeight, 1);
                        if (lstComparator[i].customerName == "STOCK")
                            palletTotalStock += Math.Round(lstComparator[i].netWeight, 1);
                        else
                            palletTotalSalesOrder += Math.Round(lstComparator[i].netWeight, 1);

                        if (productCode == "")
                            productCode = (lstComparator.Count > 0) ? lstComparator[i].productName : "";

                        if (lstComparator[i].productName == productCode)
                        {
                            totalNetWeight += Math.Round(lstComparator[i].netWeight, 1);
                            totalPalletsByProduct++;
                        }
                        else
                        {
                            dgvDetails.Rows.Add();
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = productCode;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(totalNetWeight, 1);
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.clear;

                            for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                            {
                                Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                            }

                            productCode = lstComparator[i].productName;
                            totalNetWeight = Math.Round(lstComparator[i].netWeight, 1);
                            totalPalletsByProduct = 1;
                        }


                        dgvDetails.Rows.Add();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = lstComparator[i].codsec;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clminventory.Index].Value = lstComparator[i].destination;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = lstComparator[i].productName;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = lstComparator[i].netWeight;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmgrossWeight.Index].Value = lstComparator[i].grossWeigth;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmOrigin.Index].Value = lstComparator[i].origin;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmSalesOrder.Index].Value = lstComparator[i].salesOrderNumber;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstComparator[i].customerName;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = lstComparator[i].coilCellarName;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPalletNumber.Index].Value = lstComparator[i].palletNumber;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCoilsNumber.Index].Value = lstComparator[i].coilCount.ToString();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmnave.Index].Value = lstComparator[i].nave;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmpallet.Index].Value = lstComparator[i].code;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.eye;
                        lastPosition = i;
                    }
                }
                if (lastPosition > -1)
                {
                    dgvDetails.Rows.Add();
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = productCode;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(totalNetWeight, 1);
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.clear;

                    for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                    {
                        Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                    }

                    productCode = lstComparator[lastPosition].productName;
                    totalNetWeight = Math.Round(lstComparator[lastPosition].netWeight, 1);
                    totalPalletsByProduct = 1;
                }
            }

            lblTotalPallets.Text = palletCount.ToString();
            lblTotalWeight.Text = palletTotalWeight.ToString();
            lblTotalStockWeight.Text = palletTotalStock.ToString();
            lblTotalSalesOrderWeight.Text = palletTotalSalesOrder.ToString();

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

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }
    }
}
