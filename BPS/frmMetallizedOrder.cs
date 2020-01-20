using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using System.Threading;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMetallizedOrder : Form
    {
        List<clsPallet> lstPallets = new List<clsPallet>();
        List<clsMaquile> lstMaquile = new List<clsMaquile>();
        List<int> lstDetails = new List<int>();
        clsProduct objProduct = new clsProduct();
        string source = "";
        int sorucecodsec = 0;
        int sourcesfrom = 0;
        int sourceto = 0;
        int sourcetomaquile = 0;
        int sourcetoo = 0;
        int mydetail = 0;
        int place = 0;

        bool executeFilter = true;
        bool excutefiltermaquile = true;

        delegate void showLoading();
        delegate void HideLoading();
        delegate void showLoadingMaquile();
        delegate void hideLoadingMaquile();

        showLoading showLoadImage;
        HideLoading hideLoadImage;

        showLoadingMaquile showLoadImageMaquile;
        hideLoadingMaquile hideLoadImageMaquile;

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstPallets = clsPallet.getListForBaseFilm();
            this.Invoke(hideLoadImage);
        }

        private void loadMovementsMaquile()
        {
            this.Invoke(showLoadImageMaquile);
            lstMaquile = clsMaquile.getList();
            this.Invoke(hideLoadImageMaquile);
        }

        private void showLoadingDelegate()
        {
            pbxLoading.Visible = true;
            grpbFilters.Enabled = false;
            lblLoading.Visible = true;
        }

        private void showLoadingDelegateMaquile()
        {
            pbxLoadingMaquile.Visible = true;
            grpbFilterMaquile.Enabled = false;
            lblMessageMaquile.Visible = true;
        }

        private void hideLoadingDelegate()
        {
            fillPalletInfo();

            List<string> lstFilm = new List<string>();
            List<string> lstCustomers = new List<string>();

            for (int i = 0; i < lstPallets.Count; i++)
            {
                //Film
                bool flgIsProductInList = false;
                for (int j = 0; j < lstFilm.Count; j++)
                {
                    if (lstFilm[j] == lstPallets[i].product.code)
                    {
                        flgIsProductInList = true;
                        break;
                    }
                }
                if (flgIsProductInList == false)
                    lstFilm.Add(lstPallets[i].product.code);

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
            }
            lstFilm.Sort();
            lstCustomers.Sort();

            cmbFilm.Items.Clear();
            cmbCustomer.Items.Clear();

            for (int i = 0; i < lstFilm.Count; i++)
                cmbFilm.Items.Add(lstFilm[i]);

            for (int i = 0; i < lstCustomers.Count; i++)
                cmbCustomer.Items.Add(lstCustomers[i]);

            grpbFilters.Enabled = true;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }

        private void hideLoadingDelegateMaquile()
        {
            fillMaquileInfo();

            List<string> lstProduct = new List<string>();
            List<string> lstType = new List<string>();

            for (int i = 0; i < lstMaquile.Count; i++)
            {
                //Film
                bool flgIsProductInList = false;
                for (int j = 0; j < lstProduct.Count; j++)
                {
                    if (lstProduct[j] == lstMaquile[i].name)
                    {
                        flgIsProductInList = true;
                        break;
                    }
                }
                if (flgIsProductInList == false)
                    lstProduct.Add(lstMaquile[i].name);

                //Customers
                bool flgIsCustomerInList = false;
                for (int j = 0; j < lstType.Count; j++)
                {
                    if (lstType[j] == lstMaquile[i].abbreviation)
                    {
                        flgIsCustomerInList = true;
                        break;
                    }
                }
                if (flgIsCustomerInList == false)
                    lstType.Add(lstMaquile[i].abbreviation);
            }
            lstProduct.Sort();
            lstType.Sort();

            cmbMaquileProduct.Items.Clear();
            cmbMaquileType.Items.Clear();

            for (int i = 0; i < lstProduct.Count; i++)
                cmbMaquileProduct.Items.Add(lstProduct[i]);

            for (int i = 0; i < lstType.Count; i++)
                cmbMaquileType.Items.Add(lstType[i]);

            grpbFilterMaquile.Enabled = true;
            pbxLoadingMaquile.Visible = false;
            lblMessageMaquile.Visible = false;
        }

        private void fillMaquileInfo()
        {
            int palletCount = 0;
            double palletTotalWeight = 0;
            double palletTotalStock = 0;
            double palletTotalSalesOrder = 0;

            if (excutefiltermaquile == true)
            {
                string productCode = "";
                double totalNetWeight = 0;
                int totalPalletsByProduct = 0;
                int lastPosition = -1;

                dgvMaquile.Rows.Clear();

                for (int i = 0; i < lstMaquile.Count; i++)
                {
                    bool flgInclude = false;
                    bool flgOKProduct = false;
                    bool flgOKType = false;
                    bool flgOKWidth = false;
                    bool flgOKWeigth = false;

                    if (cmbMaquileProduct.Text != "" || cmbMaquileType.Text != "" || cmbMaquileProduct.SelectedIndex > -1 || cmbMaquileType.SelectedIndex > -1 || (txtmaquilewidthto.Text != "" && txtmaquilewidthto.Text != "0") || (txtmaquileweigthto.Text != "" && txtmaquileweigthto.Text != "0"))
                    {
                        //Film
                        if (cmbMaquileProduct.SelectedIndex > -1 || cmbMaquileProduct.Text != "")
                        {
                            if (lstMaquile[i].name.ToUpper().StartsWith(cmbMaquileProduct.Text.ToString().ToUpper()))
                                flgOKProduct = true;
                        }
                        if (cmbMaquileProduct.Text == "" && cmbMaquileProduct.SelectedIndex == -1)
                            flgOKProduct = true;

                        //Type
                        if (cmbMaquileType.SelectedIndex > -1 || cmbMaquileType.Text != "")
                        {
                            if (lstMaquile[i].abbreviation.ToUpper().StartsWith(cmbMaquileType.Text.ToString().ToUpper()))
                                flgOKType = true;
                        }
                        if (cmbMaquileType.Text == "" && cmbMaquileType.SelectedIndex == -1)
                            flgOKType = true;

                        if (txtmaquilewidthto.Text != "" && txtmaquilewidthto.Text != "0")
                        {
                            if (txtmaquilewidthfrom.Text != "" && txtmaquilewidthfrom.Text != "0")
                            {
                                if (lstMaquile[i].width.ToString().StartsWith(txtmaquilewidthto.Text) && lstMaquile[i].width.ToString().StartsWith(txtmaquilewidthfrom.Text))
                                    flgOKWidth = true;
                            }
                            else
                            {
                                if (lstMaquile[i].width.ToString().StartsWith(txtmaquilewidthto.Text))
                                    flgOKWidth = true;
                            }
                        }
                        else
                            flgOKWidth = true;

                        if (txtmaquileweigthto.Text != "" && txtmaquileweigthto.Text != "0")
                        {
                            if (txtmaquileweigthfrom.Text != "" && txtmaquileweigthfrom.Text != "0")
                            {
                                if (lstMaquile[i].weigth.ToString().StartsWith(txtmaquileweigthto.Text) && lstMaquile[i].weigth.ToString().StartsWith(txtmaquileweigthfrom.Text))
                                    flgOKWeigth = true;
                            }
                            else
                            {
                                if (lstMaquile[i].weigth.ToString().StartsWith(txtmaquileweigthto.Text))
                                    flgOKWeigth = true;
                            }
                        }
                        else
                            flgOKWeigth = true;

                        if (flgOKProduct == true && flgOKType == true && flgOKWidth == true && flgOKWeigth == true)
                            flgInclude = true;
                    }
                    else
                        flgInclude = true;

                    if (flgInclude == true)
                    {
                        palletCount++;
                        palletTotalWeight += Math.Round(lstMaquile[i].weigth, 1);

                        if (lstMaquile[i].customer == "STOCK")
                            palletTotalStock += Math.Round(lstMaquile[i].weigth, 1);
                        else
                            palletTotalSalesOrder += Math.Round(lstMaquile[i].weigth, 1);

                        if (productCode == "")
                            productCode = (lstMaquile.Count > 0) ? lstMaquile[i].abbreviation : "";

                        if (lstMaquile[i].abbreviation == productCode)
                        {
                            totalNetWeight += Math.Round(lstMaquile[i].weigth, 1);
                            totalPalletsByProduct++;
                        }
                        else
                        {
                            dgvMaquile.Rows.Add();
                            dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquiletype.Index].Value = productCode;
                            dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquileweigth.Index].Value = Math.Round(totalNetWeight, 1);
                            dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquileview.Index].Value = global::BPS.Properties.Resources.clear;

                            for (int j = 0; j < dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells.Count; j++)
                            {
                                Font fntBold = new Font(dgvMaquile.Font, FontStyle.Bold);
                                dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                                dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                            }

                            productCode = lstMaquile[i].abbreviation;
                            totalNetWeight = Math.Round(lstMaquile[i].weigth, 1);
                            totalPalletsByProduct = 1;
                        }

                        dgvMaquile.Rows.Add();
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilecodsec.Index].Value = lstMaquile[i].codsec;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilefkproductto.Index].Value = lstMaquile[i].fkproductTo;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilefkproductfrom.Index].Value = lstMaquile[i].fkproductFrom;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquileproduct.Index].Value = lstMaquile[i].name;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquiletype.Index].Value = lstMaquile[i].abbreviation;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilewidth.Index].Value = lstMaquile[i].width;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilecore.Index].Value = lstMaquile[i].core;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilediameter.Index].Value = lstMaquile[i].Diameter;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilecustomer.Index].Value = lstMaquile[i].customer;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilecellar.Index].Value = lstMaquile[i].cellarName;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilepallet.Index].Value = lstMaquile[i].pallet;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquilecoil.Index].Value = lstMaquile[i].coil;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquiledate.Index].Value = lstMaquile[i].createdDate.ToString("dd/MM/yyyy");
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquileview.Index].Value = global::BPS.Properties.Resources.clear;

                        lastPosition = i;
                    }
                }
                if (lastPosition > -1)
                {
                    dgvMaquile.Rows.Add();
                    dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquiletype.Index].Value = productCode;
                    dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquileweigth.Index].Value = Math.Round(totalNetWeight, 1);
                    dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[clmmaquileview.Index].Value = global::BPS.Properties.Resources.clear;

                    for (int j = 0; j < dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells.Count; j++)
                    {
                        Font fntBold = new Font(dgvMaquile.Font, FontStyle.Bold);
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                        dgvMaquile.Rows[dgvMaquile.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                    }

                    productCode = lstMaquile[lastPosition].abbreviation;
                    totalNetWeight = Math.Round(lstMaquile[lastPosition].weigth, 1);
                    totalPalletsByProduct = 1;
                }
            }
        }

        public frmMetallizedOrder()
        {
            InitializeComponent();
            tbcChangeSalesOrder.TabPages.Remove(tbpCuttingPlan);
            tbcChangeSalesOrder.TabPages.Remove(tbpMaquilePlan);
            getMaquileList();
            getPalletList();
            panel1.Visible = false;
        }

        private void getMaquileList()
        {
            showLoadImageMaquile = new showLoadingMaquile(showLoadingDelegateMaquile);
            hideLoadImageMaquile = new hideLoadingMaquile(hideLoadingDelegateMaquile);
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

                dgvStockBackload.Rows.Clear();

                for (int i = 0; i < lstPallets.Count; i++)
                {
                    bool flgInclude = false;
                    bool flgOKFilm = false;
                    bool flgOKCustomer = false;
                    bool flgOKWidth = false;
                    bool flgOKWeigth = false;

                    if (cmbFilm.Text != "" || cmbCustomer.Text != "" || cmbFilm.SelectedIndex > -1 || cmbCustomer.SelectedIndex > -1 || (txtwidthto.Text != "" && txtwidthto.Text != "0") || (txtweigthto.Text != "" && txtweigthto.Text != "0"))
                    {
                        //Film
                        if (cmbFilm.SelectedIndex > -1 || cmbFilm.Text != "")
                        {
                            if (lstPallets[i].product.code.ToUpper().StartsWith(cmbFilm.Text.ToString().ToUpper()))
                                flgOKFilm = true;
                        }
                        if (cmbFilm.Text == "" && cmbFilm.SelectedIndex == -1)
                            flgOKFilm = true;

                        //Customer
                        if (cmbCustomer.SelectedIndex > -1 || cmbCustomer.Text != "")
                        {
                            if (lstPallets[i].customerName.ToUpper().StartsWith(cmbCustomer.Text.ToString().ToUpper()))
                                flgOKCustomer = true;
                        }
                        if (cmbCustomer.Text == "" && cmbCustomer.SelectedIndex == -1)
                            flgOKCustomer = true;

                        if (txtwidthto.Text != "" && txtwidthto.Text != "0")
                        {
                            if (txtwidthfrom.Text != "" && txtwidthfrom.Text != "0")
                            {
                                if (lstPallets[i].product.width.ToString().StartsWith(txtwidthto.Text) && lstPallets[i].product.width.ToString().StartsWith(txtwidthfrom.Text))
                                    flgOKWidth = true;
                            }
                            else
                            {
                                if (lstPallets[i].product.width.ToString().StartsWith(txtwidthto.Text))
                                    flgOKWidth = true;
                            }
                        }
                        else
                            flgOKWidth = true;

                        if (txtweigthto.Text != "" && txtweigthto.Text != "0")
                        {
                            if (txtweigthfrom.Text != "" && txtweigthfrom.Text != "0")
                            {
                                if (lstPallets[i].product.width.ToString().StartsWith(txtweigthto.Text) && lstPallets[i].product.width.ToString().StartsWith(txtweigthfrom.Text))
                                    flgOKWeigth = true;
                            }
                            else
                            {
                                if (lstPallets[i].product.width.ToString().StartsWith(txtweigthto.Text))
                                    flgOKWeigth = true;
                            }
                        }
                        else
                            flgOKWeigth = true;

                        if (flgOKFilm == true && flgOKCustomer == true && flgOKWidth == true && flgOKWeigth == true)
                            flgInclude = true;
                    }
                    else
                        flgInclude = true;

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
                            dgvStockBackload.Rows.Add();
                            dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadfilm.Index].Value = productCode;
                            dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadweigth.Index].Value = Math.Round(totalNetWeight, 1);
                            dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadviewer.Index].Value = global::BPS.Properties.Resources.clear;

                            for (int j = 0; j < dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells.Count; j++)
                            {
                                Font fntBold = new Font(dgvStockBackload.Font, FontStyle.Bold);
                                dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                                dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                            }

                            productCode = lstPallets[i].product.code;
                            totalNetWeight = Math.Round(lstPallets[i].netWeight, 1);
                            totalPalletsByProduct = 1;
                        }

                        dgvStockBackload.Rows.Add();
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadcodsec.Index].Value = lstPallets[i].fkProduct;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadfilm.Index].Value = lstPallets[i].product.code;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadwidth.Index].Value = lstPallets[i].product.width;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloaddiameter.Index].Value = lstPallets[i].product.DiameterAbbreviation;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadcore.Index].Value = lstPallets[i].product.CoreValue;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadweigth.Index].Value = Math.Round(lstPallets[i].netWeight, 1).ToString();
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadorigin.Index].Value = lstPallets[i].origin;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadorder.Index].Value = lstPallets[i].salesOrderNumber;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadcustomer.Index].Value = lstPallets[i].customerName;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadlotnumber.Index].Value = lstPallets[i].lotNumber;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadcellar.Index].Value = lstPallets[i].coilCellarName;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadpallet.Index].Value = lstPallets[i].palletNumber;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadcoil.Index].Value = lstPallets[i].coilCount.ToString();
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloaddateextrusion.Index].Value = lstPallets[i].extrusionDate.ToString("dd/MM/yyyy");
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadviewer.Index].Value = global::BPS.Properties.Resources.clear;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadfkpallet.Index].Value = lstPallets[i].codsec;
                        
                        lastPosition = i;
                    }
                }
                if (lastPosition > -1)
                {
                    dgvStockBackload.Rows.Add();
                    dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadfilm.Index].Value = productCode;
                    dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadweigth.Index].Value = Math.Round(totalNetWeight, 1);
                    dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadviewer.Index].Value = global::BPS.Properties.Resources.clear;

                    for (int j = 0; j < dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells.Count; j++)
                    {
                        Font fntBold = new Font(dgvStockBackload.Font, FontStyle.Bold);
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                    }

                    productCode = lstPallets[lastPosition].product.code;
                    totalNetWeight = Math.Round(lstPallets[lastPosition].netWeight, 1);
                    totalPalletsByProduct = 1;
                }
            }
        }

        private void loadComboMachine()
        {
            List<clsMachine> lstMachine = new List<clsMachine>();
            cmbMachine.Items.Clear();
            if (cmbMachine.SelectedIndex + 1 >= 0)
            {
                lstMachine = clsMachine.getMetallizerMachineList();
                for (int i = 0; i < lstMachine.Count; i++)
                    cmbMachine.Items.Add(lstMachine[i]);
            }
        }

        private void frmMetallizedOrder_Load(object sender, EventArgs e)
        {
            Thread tdm = new Thread(new ThreadStart(this.loadMovementsMaquile));
            tdm.Start();

            Thread td = new Thread(new ThreadStart(this.loadMovements));
            td.Start();

            PopulateSumary();
        }

        private void btnRefreshBopp_Click(object sender, EventArgs e)
        {
            dgvStockBackload.Rows.Clear();
            Thread td = new Thread(new ThreadStart(this.loadMovements));
            td.Start();
        }

        private void cmbFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilm.SelectedIndex > -1)
                fillPalletInfo();
        }

        private void cmbCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex > -1)
                fillPalletInfo();
        }

        private void txtwidthto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void txtwidthfrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void txtweigthto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void txtweigthfrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            executeFilter = false;

            cmbFilm.SelectedIndex = -1;
            cmbFilm.Text = "";
            cmbCustomer.SelectedIndex = -1;
            cmbCustomer.Text = "";
            txtwidthfrom.Clear();
            txtwidthto.Clear();
            txtweigthfrom.Clear();
            txtweigthto.Clear();
            executeFilter = true;

            fillPalletInfo();
        }

        private void cmbMaquileProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex > -1)
                fillMaquileInfo();
        }

        private void cmbMaquileProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillMaquileInfo();
        }

        private void cmbMaquileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex > -1)
                fillMaquileInfo();
        }

        private void cmbMaquileType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillMaquileInfo();
        }

        private void txtmaquilewidthto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillMaquileInfo();
        }

        private void txtmaquilewidthfrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillMaquileInfo();
        }

        private void txtmaquileweigthto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillMaquileInfo();
        }

        private void txtmaquileweigthfrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillMaquileInfo();
        }

        private void btnMaquileClearFilter_Click(object sender, EventArgs e)
        {
            excutefiltermaquile = false;

            cmbMaquileProduct.SelectedIndex = -1;
            cmbMaquileProduct.Text = "";
            cmbMaquileType.SelectedIndex = -1;
            cmbMaquileType.Text = "";
            txtmaquilewidthfrom.Clear();
            txtmaquilewidthto.Clear();
            txtmaquileweigthfrom.Clear();
            txtmaquileweigthto.Clear();
            excutefiltermaquile = true;

            fillMaquileInfo();
        }

        private void btnMaquileRefresh_Click(object sender, EventArgs e)
        {
            dgvMaquile.Rows.Clear();
            Thread tdm = new Thread(new ThreadStart(this.loadMovementsMaquile));
            tdm.Start();
        }

        private void dgvStockBackload_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToInt32(dgvStockBackload.Rows[e.RowIndex].Cells[clmbackloadcodsec.Index].Value) > 0)
                {
                    objProduct.load(Convert.ToInt32(dgvStockBackload.Rows[e.RowIndex].Cells[clmbackloadcodsec.Index].Value));
                    lblBaseFilm.Text = "[" + objProduct.boppCode + "] ";
                    lblMetalFilm.Text = "[" + clsProduct.getMetalizeFormBaseFilm(objProduct.Bopp.Thickness.codsec, objProduct.boppCode, objProduct.fkBopp) + "] ";
                    lblFrom.Text = lblMetalFilm.Text;
                    FillSalesOrderByFilm(clsProduct.getMetalizeFormBaseFilmCodsec(objProduct.Bopp.Thickness.codsec, objProduct.boppCode, objProduct.fkBopp));
                    source = "Pallet";
                    sorucecodsec = Convert.ToInt32(dgvStockBackload.Rows[e.RowIndex].Cells[clmbackloadfkpallet.Index].Value);
                    sourcesfrom = objProduct.codsec;
                    txtInnerProduction.Text = Math.Round(Convert.ToDouble(dgvStockBackload.Rows[e.RowIndex].Cells[clmbackloadweigth.Index].Value), 2).ToString();
                    calculateTotals();
                    lblFrom.Text = dgvStockBackload.Rows[e.RowIndex].Cells[clmbackloadfilm.Index].Value.ToString();
                    tbcChangeSalesOrder.TabPages.Remove(tbpCuttingPlan);
                    tbcChangeSalesOrder.TabPages.Insert(1, tbpCuttingPlan);
                    tbcChangeSalesOrder.SelectedIndex = 1;
                    loadComboMachine();
                }
                else
                    MessageBox.Show("Por favor seleccione un producto válido", "Ordenes Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void calculateTotals()
        {
            double totalSalesOrder = 0;
            double totalInnerProduction = 0;

            for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvSalesOrder.Rows[i].Cells[clmsalesin.Index].Value) == true)
                    totalSalesOrder += Convert.ToDouble(dgvSalesOrder.Rows[i].Cells[clmsalesweigth.Index].Value);
            }

            totalInnerProduction = Convert.ToDouble(txtInnerProduction.Text);
            lblSalesOrderTotalValue.Text = totalSalesOrder.ToString();

            lblTotal.Text = Math.Round(((totalSalesOrder + totalInnerProduction) * (1 + (Convert.ToDouble(nudExtraPercentage.Value) / 100))), 2).ToString();
        }

        private void FillSalesOrderByFilm(int codsec)
        {
            List<clsSalesOrder> lstSalesOrder = clsSalesOrder.getListByMetalizedProduct(codsec);
            dgvSalesOrder.Rows.Clear();

            if (lstSalesOrder.Count > 0)
            {
                for (int i = 0; i < lstSalesOrder.Count; i++)
                {
                    dgvSalesOrder.Rows.Add();
                    dgvSalesOrder.Rows[i].Cells[clmsalescodsec.Index].Value = lstSalesOrder[i].codsec.ToString();
                    dgvSalesOrder.Rows[i].Cells[clmsalesfkproduct.Index].Value = lstSalesOrder[i].fkProduct.ToString();
                    dgvSalesOrder.Rows[i].Cells[clmsalescodsecdetail.Index].Value = lstSalesOrder[i].codsecDetail.ToString();
                    dgvSalesOrder.Rows[i].Cells[clmsalesproduct.Index].Value = lstSalesOrder[i].product.ToString();
                    dgvSalesOrder.Rows[i].Cells[clmsalescustomer.Index].Value = lstSalesOrder[i].EntityName.ToString();
                    dgvSalesOrder.Rows[i].Cells[clmsalesorder.Index].Value = lstSalesOrder[i].number.ToString();
                    dgvSalesOrder.Rows[i].Cells[clmsalesweigth.Index].Value = lstSalesOrder[i].quantity.ToString();
                    dgvSalesOrder.Rows[i].Cells[clmsalesdate.Index].Value = lstSalesOrder[i].createdDate.ToShortDateString();
                    dgvSalesOrder.Rows[i].Cells[clmsalescuttingweigth.Index].Value = Math.Round(lstSalesOrder[i].totalByBoppFilm, 2, MidpointRounding.AwayFromZero).ToString();
                    dgvSalesOrder.Rows[i].Cells[clmsalesisinternational.Index].Value = (lstSalesOrder[i].isInternationalSale == true) ? global::BPS.Properties.Resources.world : global::BPS.Properties.Resources.table;
                }
            }
            else
            {
                dgvSalesOrder.Rows.Clear();
                chkStock.Enabled = true;
                chkStock.Checked = false;
            }
        }

        private void dgvMaquile_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToInt32(dgvMaquile.Rows[e.RowIndex].Cells[clmmaquilecodsec.Index].Value) > 0)
                {
                    objProduct.load(Convert.ToInt32(dgvMaquile.Rows[e.RowIndex].Cells[clmmaquilefkproductto.Index].Value));
                    lblMaquileFrom.Text = "[" + dgvMaquile.Rows[e.RowIndex].Cells[clmmaquiletype.Index].Value.ToString() + "] ";
                    lblMaquileTo.Text = "[" + objProduct.boppCode + "] ";
                    lblMaquileBaseFrom.Text = lblMaquileFrom.Text;
                    source = "Maquile";
                    sorucecodsec = Convert.ToInt32(dgvMaquile.Rows[e.RowIndex].Cells[clmmaquilecodsec.Index].Value);
                    sourcesfrom = Convert.ToInt32(dgvMaquile.Rows[e.RowIndex].Cells[clmmaquilefkproductfrom.Index].Value);
                    sourcetomaquile = objProduct.codsec;
                    lblMaquileMetalizedProduct.Text = objProduct.code;
                    objProduct.load(sourcesfrom);
                    lblMaquileBaseFrom.Text = objProduct.code;
                    tbcChangeSalesOrder.TabPages.Remove(tbpMaquilePlan);
                    tbcChangeSalesOrder.TabPages.Insert(1, tbpMaquilePlan);
                    tbcChangeSalesOrder.SelectedIndex = 1;
                    loadMaquileMachine();
                }
                else
                    MessageBox.Show("Por favor seleccione un producto válido", "Ordenes Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void loadMaquileMachine()
        {
            List<clsMachine> lstMachine = new List<clsMachine>();
            cmbMaquileMachine.Items.Clear();
            if (cmbMaquileMachine.SelectedIndex + 1 >= 0)
            {
                lstMachine = clsMachine.getMetallizerMachineList();
                for (int i = 0; i < lstMachine.Count; i++)
                    cmbMaquileMachine.Items.Add(lstMachine[i]);
            }
        }

        private void txtCoilCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clsCoil ObjCoil = new clsCoil();
                ObjCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
                if (ObjCoil.codsec > 0)
                {
                    if (ObjCoil.fkStatus == 35 || ObjCoil.fkStatus == 36)
                    {
                        MessageBox.Show("No puede asignar una bobina que se encuentre DESTRUIDA / ELIMINADA", "Ordenes Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtCoilCode.Clear();
                        txtCoilCode.Focus();
                    }
                    else
                    {
                        dgvCoil.Rows.Add();
                        dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilfkbopp.Index].Value = ObjCoil.fkBopp;
                        dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilcodsec.Index].Value = ObjCoil.codsec;
                        dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilfilm.Index].Value = ObjCoil.ProductCode;
                        dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilwidth.Index].Value = ObjCoil.width;
                        dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoildiameter.Index].Value = ObjCoil.diameteres;
                        dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilcore.Index].Value = ObjCoil.core;
                        dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilweigth.Index].Value = ObjCoil.netWeight;
                        dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilorigin.Index].Value = ObjCoil.origin;
                        dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilorder.Index].Value = ObjCoil.salesOrderNumber;
                        dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilcustomer.Index].Value = ObjCoil.customerName;
                        dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoillotnumber.Index].Value = ObjCoil.lotNumber;
                        dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilfkproduct.Index].Value = ObjCoil.fkProduct;
                        dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoildate.Index].Value = ObjCoil.createdDate.ToShortDateString();
                        dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilviewer.Index].Value = global::BPS.Properties.Resources.clear;
                        dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoildelete.Index].Value = global::BPS.Properties.Resources.cross;
                    }
                }
                else
                {
                    MessageBox.Show("Código no existente por favor verifique que el código ingresado sea el correcto", "Ordenes Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    txtCoilCode.Clear();
                    txtCoilCode.Focus();
                }
            }
        }

        private void dgvCoil_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToInt32(dgvStockBackload.Rows[e.RowIndex].Cells[clmcoilcodsec.Index].Value) > 0)
                {
                    objProduct.load(Convert.ToInt32(dgvCoil.Rows[e.RowIndex].Cells[clmcoilfkproduct.Index].Value));
                    lblBaseFilm.Text = "[" + objProduct.boppCode + "] ";
                    lblMetalFilm.Text = "[" + clsProduct.getMetalizeFormBaseFilm(objProduct.Bopp.Thickness.codsec, objProduct.boppCode, objProduct.fkBopp) + "] ";
                    lblFrom.Text = dgvCoil.Rows[e.RowIndex].Cells[clmcoilfilm.Index].Value.ToString();
                    FillSalesOrderByFilm(clsProduct.getMetalizeFormBaseFilmCodsec(objProduct.Bopp.Thickness.codsec, objProduct.boppCode, objProduct.fkBopp));
                    source = "Coil";
                    sorucecodsec = Convert.ToInt32(dgvCoil.Rows[e.RowIndex].Cells[clmcoilcodsec.Index].Value);
                    sourcesfrom = objProduct.codsec;
                    txtInnerProduction.Text = Math.Round(Convert.ToDouble(dgvCoil.Rows[e.RowIndex].Cells[clmcoilweigth.Index].Value), 2).ToString();
                    calculateTotals();
                    tbcChangeSalesOrder.TabPages.Remove(tbpCuttingPlan);
                    tbcChangeSalesOrder.TabPages.Insert(1, tbpCuttingPlan);
                    tbcChangeSalesOrder.SelectedIndex = 1;
                    loadComboMachine();
                }
                else
                    MessageBox.Show("Por favor seleccione un producto válido", "Ordenes Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void dgvCoil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmcoildelete.Index)
            {
                MessageBox.Show("Esta realmente seguro que desea eliminar la bobina seleccionada?", "Ordenes Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                dgvCoil.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvSalesOrder_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[clmsalesisinternational.Index].Value = global::BPS.Properties.Resources.clear;
            e.Row.Cells[clmsalesin.Index].Value = false;
            e.Row.Cells[clmsalesproduct.Index].Value = "";
        }

        private void btnClearCoil_Click(object sender, EventArgs e)
        {
            dgvCoil.Rows.Clear();
            txtCoilCode.Clear();
            txtCoilCode.Focus();
        }

        private void chkStock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStock.Checked)
            {
                panel1.Visible = true;
                PopulateMetalProduct();
                place = 1;
            }
            else
            {
                panel1.Visible = false;
                PopulateMetalProduct();
                place = 0;
            }
        }

        private void PopulateMetalProduct()
        {
            List<clsMetalizedProduct> lstProduct = new List<clsMetalizedProduct>();
            lstProduct = clsMetalizedProduct.getListMetalProduct();
            cmbProductto.Items.Clear();
            for (int i = 0; i < lstProduct.Count; i++)
                cmbProductto.Items.Add(lstProduct[i]);

            List<clsMetalizedProduct> lstProductM = new List<clsMetalizedProduct>();
            lstProductM = clsMetalizedProduct.getListMetalProduct();
            cmbProducttoo.Items.Clear();
            for (int i = 0; i < lstProductM.Count; i++)
                cmbProducttoo.Items.Add(lstProductM[i]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateFrom())
            {
                if (Convert.ToDouble(nudCoilsToChange.Value) > 0)
                {
                    clsMetallizedOrder ObjMetalizeOrder = new clsMetallizedOrder();
                    ObjMetalizeOrder.fkMachine = ((clsMachine)cmbMachine.SelectedItem).codsec;
                    ObjMetalizeOrder.fkproductFrom = sourcesfrom;
                    ObjMetalizeOrder.fkproductTo = (place == 0) ? sourceto : ((clsMetalizedProduct)cmbProductto.SelectedItem).codsec;
                    ObjMetalizeOrder.fkproductToo = (place == 0) ? sourcetoo : (cmbProducttoo.SelectedItem == null) ? 0 : ((clsMetalizedProduct)cmbProducttoo.SelectedItem).codsec;
                    ObjMetalizeOrder.number = clsSequential.SequentialList("metallizedOrder").ToString();
                    ObjMetalizeOrder.opticDensity = Convert.ToDouble(txtopticDensity.Text);
                    ObjMetalizeOrder.quantityCoils = Convert.ToDouble(nudCoilsToChange.Value);
                    ObjMetalizeOrder.notes = txtNotes.Text;
                    ObjMetalizeOrder.kg = Convert.ToDouble(txtkg.Text);
                    ObjMetalizeOrder.totalweigth = Convert.ToDouble(lblTotal.Text);
                    ObjMetalizeOrder.fkoriginbase = sorucecodsec;
                    ObjMetalizeOrder.codsecdetail = mydetail;
                    ObjMetalizeOrder.type = source;
                    ObjMetalizeOrder.lotnumber = GenerateLotNumber();
                    ObjMetalizeOrder.initDate = Convert.ToDateTime(dtpInitDate.Value);
                    if (ObjMetalizeOrder.savewithdetail(lstDetails))
                    {
                        MessageBox.Show("Orden  de Metalizado Generada Correctamente", "Ordenes Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        PopulateSumary();
                        tbcChangeSalesOrder.SelectedIndex = 2;
                        ClearMyData();
                    } 
                }
                else
                    MessageBox.Show("Debe asignar por lo menos una bobina para metalizar", "Ordenes Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private string GenerateLotNumber()
        {
            return DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + "5" + clsGlobal.FillWithZeros(((new clsSequential().metallizedOrder).ToString()), 4);
        }

        private void ClearMyData()
        {
            dgvSalesOrder.Rows.Clear();
            lblSalesOrderTotalValue.Text = "0";
            txtInnerProduction.Text = "0";
            nudExtraPercentage.Value = 0;
            lblTotal.Text = "0";
            lblFrom.Text = "";
            lblProductoTo.Text = "";
            lblProductoToo.Text = "";
            nudCoilsToChange.Value = 0;
            lblBaseFilm.Text = "";
            lblMetalFilm.Text = "";
            chkStock.Checked = false;
            txtNotes.Clear();
            cmbMachine.Text = "";
            cmbMachine.SelectedIndex = -1;
            txtopticDensity.Clear();
            txtCoilCode.Clear();
            dgvCoil.Rows.Clear();
            panel1.Visible = false;
            cmbProductto.SelectedIndex = -1;
            cmbProductto.SelectedItem = -1;
            cmbProductto.Text = "";
            cmbProducttoo.SelectedIndex = -1;
            cmbProducttoo.SelectedItem = -1;
            cmbProducttoo.Text = "";
            place = 0;
            sourceto = 0;
            sourcetoo = 0;
            tbcChangeSalesOrder.TabPages.Remove(tbpCuttingPlan);
            tbcChangeSalesOrder.TabPages.Remove(tbpMaquilePlan);
            lstDetails.Clear();
        }

        private void PopulateSumary()
        {
            List<clsMetallizedOrder> lstMetalizeOrder = new List<clsMetallizedOrder>();
            lstMetalizeOrder = clsMetallizedOrder.getActiveOrderListSummary();
            dgvSummary.Rows.Clear();
            for (int i = 0; i < lstMetalizeOrder.Count; i++)
            {
                dgvSummary.Rows.Add();
                dgvSummary.Rows[i].Cells[clmsummarycodsec.Index].Value = lstMetalizeOrder[i].codsec;
                dgvSummary.Rows[i].Cells[cclmsummarystatus.Index].Value = (lstMetalizeOrder[i].fkStatus == 46) ? global::BPS.Properties.Resources.blog : global::BPS.Properties.Resources.play_sharp;
                dgvSummary.Rows[i].Cells[clmsummarycustomerfrom.Index].Value = lstMetalizeOrder[i].customerfrom;
                dgvSummary.Rows[i].Cells[clmsummaryproductfrom.Index].Value = lstMetalizeOrder[i].productFromName;
                dgvSummary.Rows[i].Cells[clmsummarycustomerto.Index].Value = lstMetalizeOrder[i].customerto;
                dgvSummary.Rows[i].Cells[clmsummaryproductto.Index].Value = lstMetalizeOrder[i].productToName;
                dgvSummary.Rows[i].Cells[clmsummarycoil.Index].Value = lstMetalizeOrder[i].quantityCoils;
                dgvSummary.Rows[i].Cells[clmsummaryinitdate.Index].Value = lstMetalizeOrder[i].initDate.ToShortDateString();
                dgvSummary.Rows[i].Cells[clmsummarylotnumber.Index].Value = lstMetalizeOrder[i].lotnumber;
                dgvSummary.Rows[i].Cells[clmsummarycancel.Index].Value = global::BPS.Properties.Resources.cross;
            }
        }

        private bool validateFrom()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtopticDensity, ref lblopticDensity, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbMachine, ref lblMachine, "selected")) isValid = false;
            if (place != 0)
                if (!clsValidation.validateField(ref cmbProductto, ref lblFor, "selected")) isValid = false;

            return isValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está realmente seguro que desea cancelar la orden de metalizado?", "Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                this.Close();
        }

        private void lblTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudExtraPercentage_ValueChanged(object sender, EventArgs e)
        {
            calculateTotals();
        }

        private void txtInnerProduction_TextChanged(object sender, EventArgs e)
        {
            calculateTotals();
        }

        private void lblTotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtInnerProduction_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmsummarycancel.Index)
            {
                if (MessageBox.Show("Esta realmente seguro que desea anular la orden de metalizado?", "Ordenes Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    clsMetallizedOrder.toCrossOrder(Convert.ToInt32(dgvSummary.Rows[e.RowIndex].Cells[clmsummarycodsec.Index].Value));
                    PopulateSumary();
                }
            }
        }

        private void dgvSalesOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int count = 0, pos=0;
            string firtscheck = "", secondcheck = "";
            sourceto = 0;
            sourcetoo = 0;
            lstDetails.Clear();

            if (e.ColumnIndex >= clmsalesin.Index)
            {
                for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
                {
                    if (dgvSalesOrder.Rows[i].Cells[clmsalesin.Index].Value != null)
                    {
                        if ((bool)dgvSalesOrder.Rows[i].Cells[clmsalesin.Index].Value)
                            count++;
                    }
                }

                if (count > 0 && count <= 2)
                {
                    for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
                    {
                        if (dgvSalesOrder.Rows[i].Cells[clmsalesin.Index].Value != null)
                        {
                            if ((bool)dgvSalesOrder.Rows[i].Cells[clmsalesin.Index].Value)
                            {
                                if (firtscheck == "")
                                {
                                    firtscheck = dgvSalesOrder.Rows[i].Cells[clmsalesproduct.Index].Value.ToString();
                                    clsProduct objProduct = new clsProduct();
                                    objProduct.load(dgvSalesOrder.Rows[i].Cells[clmsalesproduct.Index].Value.ToString());
                                    sourceto = objProduct.codsec;
                                    lstDetails.Add(Convert.ToInt32(dgvSalesOrder.Rows[i].Cells[clmsalescodsecdetail.Index].Value));
                                    pos = i;
                                }
                                else if (firtscheck != "" || firtscheck != dgvSalesOrder.Rows[i].Cells[clmsalesproduct.Index].Value.ToString() && pos != i)
                                {
                                    secondcheck = dgvSalesOrder.Rows[i].Cells[clmsalesproduct.Index].Value.ToString();
                                    clsProduct objProduct = new clsProduct();
                                    objProduct.load(dgvSalesOrder.Rows[i].Cells[clmsalesproduct.Index].Value.ToString());
                                    sourcetoo = objProduct.codsec;
                                    lstDetails.Add(Convert.ToInt32(dgvSalesOrder.Rows[i].Cells[clmsalescodsecdetail.Index].Value));
                                }
                            }
                        }
                    }
                    lblProductoTo.Text = firtscheck;
                    lblProductoToo.Text = secondcheck;
                }
                else if (count > 2)
                {
                    MessageBox.Show("Solo puede seleccionar dos productos", "Ordenes Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    dgvSalesOrder.Rows[e.RowIndex].Cells[clmsalesin.Index].Value = null;
                    dgvSalesOrder.Rows[e.RowIndex].Cells[clmsalesin.Index].Value = false;
                }
            }
        }

        private void btnSaveMaquile_Click(object sender, EventArgs e)
        {
            if (validateFromMaquile())
            {
                if (Convert.ToDouble(nupdMaquile.Value) > 0)
                {
                    clsMetallizedOrder ObjMetalizeOrder = new clsMetallizedOrder();
                    ObjMetalizeOrder.fkMachine = ((clsMachine)cmbMaquileMachine.SelectedItem).codsec;
                    ObjMetalizeOrder.fkproductFrom = sourcesfrom;
                    ObjMetalizeOrder.fkproductTo = sourcetomaquile;
                    ObjMetalizeOrder.fkproductToo = 0;
                    ObjMetalizeOrder.number = clsSequential.SequentialList("metallizedOrder").ToString();
                    ObjMetalizeOrder.opticDensity = Convert.ToDouble(txtMaquileDensity.Text);
                    ObjMetalizeOrder.quantityCoils = Convert.ToDouble(nupdMaquile.Value);
                    ObjMetalizeOrder.notes = txtMaquileNotes.Text;
                    ObjMetalizeOrder.kg = Convert.ToDouble(txtMaquileKG.Text);
                    ObjMetalizeOrder.totalweigth = clsMaquile.getWeigthByCodsec(sorucecodsec);
                    ObjMetalizeOrder.fkoriginbase = sorucecodsec;
                    ObjMetalizeOrder.codsecdetail = 0;
                    ObjMetalizeOrder.type = source;
                    ObjMetalizeOrder.lotnumber = GenerateLotNumber();
                    ObjMetalizeOrder.initDate = Convert.ToDateTime(dtpMaquileInitDate.Value);
                    lstDetails.Clear();
                    if (ObjMetalizeOrder.savewithdetail(lstDetails))
                    {
                        MessageBox.Show("Orden  de Metalizado Generada Correctamente", "Ordenes Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        PopulateSumary();
                        tbcChangeSalesOrder.SelectedIndex = 2;
                        ClearMyDataMaquile();
                    }
                }
                else
                    MessageBox.Show("Debe asignar por lo menos una bobina para metalizar", "Ordenes Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void ClearMyDataMaquile()
        {
            nupdMaquile.Value = 0;

            lblMaquileFrom.Text = "";
            lblMaquileTo.Text = "";
            lblMaquileBaseFrom.Text = "";
            source = " ";
            sorucecodsec = 0;
            sourcesfrom = 0;
            sourcetomaquile = 0;
            lblMaquileMetalizedProduct.Text = "";
            lblMaquileBaseFrom.Text = "";
            txtMaquileNotes.Clear();
            cmbMaquileMachine.Text = "";
            cmbMaquileMachine.SelectedIndex = -1;
            txtMaquileDensity.Clear();
            tbcChangeSalesOrder.TabPages.Remove(tbpCuttingPlan);
            tbcChangeSalesOrder.TabPages.Remove(tbpMaquilePlan);
            lstDetails.Clear();
        }

        private bool validateFromMaquile()
        {
            bool isValid = true;
            if (!clsValidation.validateField(ref txtMaquileDensity, ref lblMaquileDensity, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbMaquileMachine, ref lblMaquileMachineLabel, "selected")) isValid = false;
            return isValid;
        }
    }
}
